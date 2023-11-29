using audio_ecommerce.Models.DTOs.Pagination;
using audio_ecommerce.Models.DTOs.Product;
using audio_ecommerce.Repositories;
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
        public PaginationWrapper<ProductPreviewDTO> GetAll(ProductFilterQuery query)
        {

            var products = _unitOfWork.ProductRepository.GetAll().Include(product => product.Artist).Where(p => p.Name.Contains(query.SearchQuery) || p.Artist.Name.Contains(query.SearchQuery));



            if (query.ArtistId != 0)
            {
                products = products.Where(p => p.ArtistId == query.ArtistId);
            }

            var count = products.Count();

            List<ProductPreviewDTO> filteredProducts = new List<ProductPreviewDTO>();

            if (query.IsOrderAscending)
            {
                filteredProducts = _mapper.Map<List<ProductPreviewDTO>>(products.OrderBy(t => t.Name).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }
            else
            {
                filteredProducts = _mapper.Map<List<ProductPreviewDTO>>(products.OrderByDescending(t => t.Name).Skip((query.Page - 1) * query.PageSize).Take(query.PageSize));
            }

            return new PaginationWrapper<ProductPreviewDTO>
            {
                TotalCount = count,
                Entities = filteredProducts
            };


        }

    }
}
