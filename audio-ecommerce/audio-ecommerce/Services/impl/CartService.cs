using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.Cart;
using audio_ecommerce.Repositories;
using audio_ecommerce.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using AutoMapper;

namespace audio_ecommerce.Services.impl
{
    public class CartService : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CartService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }


        public bool AddItemToCart(int productId, int userId)
        {
            int cartId = _unitOfWork.CartRepository.GetAll().Where(c => !c.IsDeleted).FirstOrDefault(c => c.UserId == userId).Id;

            Cart cart = _unitOfWork.CartRepository.GetById(cartId);


            Product product = _unitOfWork.ProductRepository.GetById(productId);

            Console.WriteLine(product.Name + cart.UserId);

            if (product != null)
            {

                var cartItem = new CartItem
                {
                    ProductId = product.Id,
                    Quantity = 1,
                    CartId = cartId,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsDeleted = false

                };
                cart.CartItems.Add(cartItem);
                _unitOfWork.SaveChanges();

                return true;
            }
            else
            {
                throw new NotFoundException("Product with sent ID does not exist!");

            }

        }

        public bool RemoveItemFromCart(int productId, int userId)
        {
            return false;
        }

        public CartDTO GetCart(int userId)
        {
            int cartId = _unitOfWork.CartRepository.GetAll().Where(c => !c.IsDeleted).FirstOrDefault(c => c.UserId == userId).Id;
            Cart cart = _unitOfWork.CartRepository.GetById(cartId, c => c.CartItems);
            var CartItems = new List<CartItemDTO>();

            foreach (var cartItem in cart.CartItems)
            {
                var product = _unitOfWork.ProductRepository.GetById(cartItem.ProductId, p => p.Artist);

                CartItems.Add(new CartItemDTO(product.Id, product.Name, product.Artist.Name,
                     cartItem.Quantity, product.Price, product.ImageUrl, product.Amount));
            }

            return new CartDTO(CartItems, cart.Total);


        }
    }
}
