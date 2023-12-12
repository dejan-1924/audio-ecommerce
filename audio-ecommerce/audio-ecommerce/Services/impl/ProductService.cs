using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.Artist;
using audio_ecommerce.Models.DTOs.Pagination;
using audio_ecommerce.Models.DTOs.Product;
using audio_ecommerce.Repositories;
using audio_ecommerce.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace audio_ecommerce.Services.impl
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }



        public void Delete(int productId)
        {
            Product? product = _unitOfWork.ProductRepository.GetById(productId);
            if (product == null)
            {
                throw new NotFoundException("Product with sent ID does not exist!");
            }
            Console.WriteLine(product.Name);
            _unitOfWork.ProductRepository.Delete(product);

        }


        public PaginationWrapper<ProductPreviewDTO> GetAll(ProductFilterQuery query)
        {

            var products = _unitOfWork.ProductRepository.GetAll().Include(product => product.Artist).Include(product => product.Label).Include(product => product.Format).Where(p => p.Name.Contains(query.SearchQuery) || p.Artist.Name.Contains(query.SearchQuery)).Where(p => !p.IsDeleted);

            if (query.FormatIds != null && query.FormatIds.Any())
            {
                products = products.Where(p => query.FormatIds.Contains(p.FormatId));
            }

            if (query.ArtistIds != null && query.ArtistIds.Any())
            {
                products = products.Where(p => query.ArtistIds.Contains(p.ArtistId));
            }

            if (query.LabelIds != null && query.LabelIds.Any())
            {
                products = products.Where(p => query.LabelIds.Contains(p.LabelId));
            }

            var artistGroupedProducts = products.GroupBy(p => p.ArtistId).ToList();
            var formatGroupedProducts = products.GroupBy(p => p.FormatId).ToList();
            var labelGroupedProducts = products.GroupBy(p => p.LabelId).ToList();

            var artistProductCount = artistGroupedProducts
                .Select(group => new ArtistCountDTO(group.Key, group.First().Artist.Name, group.Count()));

            var formatProductCount = formatGroupedProducts
                .Select(group => new ArtistCountDTO(group.Key, group.First().Format.Name, group.Count()));

            var labelProductCount = labelGroupedProducts
                .Select(group => new ArtistCountDTO(group.Key, group.First().Label.Name, group.Count()));

            var count = products.Count();

            List<ProductPreviewDTO> filteredProducts = new List<ProductPreviewDTO>();

            if (query.Ordering == "PRICE_ASC")
            {
                filteredProducts = _mapper.Map<List<ProductPreviewDTO>>(products.OrderBy(t => t.Price).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            else if (query.Ordering == "PRICE_DESC")
            {
                filteredProducts = _mapper.Map<List<ProductPreviewDTO>>(products.OrderByDescending(t => t.Price).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            else if (query.Ordering == "AZ")
            {
                filteredProducts = _mapper.Map<List<ProductPreviewDTO>>(products.OrderBy(t => t.Name).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            else
            {
                filteredProducts = _mapper.Map<List<ProductPreviewDTO>>(products.OrderByDescending(t => t.CreatedDate).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }



            return new PaginationWrapper<ProductPreviewDTO>
            {
                TotalCount = count,
                Entities = filteredProducts,
                Artists = artistProductCount,
                Formats = formatProductCount,
                Labels = labelProductCount
            };

        }

        public ProductDTO GetProductById(int id)
        {
            Product? product = _unitOfWork.ProductRepository.GetById(id, p => p.Artist, p => p.Label, p => p.Format);
            if (product == null)
            {
                throw new NotFoundException("Product with sent ID does not exist!");
            }
            return _mapper.Map<ProductDTO>(product);
        }

    }
}
