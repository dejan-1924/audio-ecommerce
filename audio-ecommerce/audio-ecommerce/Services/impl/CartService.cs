using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.Cart;
using audio_ecommerce.Repositories;
using audio_ecommerce.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

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


        public bool AddItemToCart(int productId, int quantity, bool isReplace, int userId)
        {
            int cartId = _unitOfWork.CartRepository.GetAll().Where(c => !c.IsDeleted).FirstOrDefault(c => c.UserId == userId).Id;


            var cart = _unitOfWork.CartRepository.GetAll().Include(c => c.CartItems).ThenInclude(ci => ci.Product).FirstOrDefault(c => c.Id == cartId && !c.IsDeleted);
            if (cart == null)
            {
                throw new NotFoundException("Cart with sent ID does not exist!");
            }

            if (cart.CartItems == null)
            {
                cart.CartItems = new List<CartItem>();
            }

            Product product = _unitOfWork.ProductRepository.GetById(productId);


            if (product == null)
            {
                throw new NotFoundException("Product with sent ID does not exist!");

            }

            var existingCartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);


            if (quantity > product.Amount)
            {
                throw new BadRequestException("Selected amount is not available for this product.");
            }



            if (existingCartItem != null)
            {

                if (!isReplace)
                {
                    if (existingCartItem.Quantity + quantity > product.Amount)
                    {
                        throw new NotFoundException("Selected amount is not available for this product.");
                    }
                    existingCartItem.Quantity += quantity;
                }
                else
                {
                    if (quantity > product.Amount)
                    {
                        throw new NotFoundException("Selected amount is not available for this product.");
                    }

                    existingCartItem.Quantity = quantity;
                }

            }
            else
            {
                var cartItem = new CartItem
                {
                    ProductId = product.Id,
                    Quantity = quantity,
                    CartId = cartId,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsDeleted = false

                };
                cart.CartItems.Add(cartItem);
            }



            double total = 0;
            foreach (var item in cart.CartItems)
            {

                var productPrice = _unitOfWork.ProductRepository.GetById(item.ProductId).Price;
                total += productPrice * item.Quantity;
            }
            cart.Total = total;

            cart.ModifiedDate = DateTime.Now;

            _unitOfWork.SaveChanges();


            return true;
        }




        public bool RemoveItemFromCart(int productId, int userId)
        {
            int cartId = _unitOfWork.CartRepository.GetAll().Where(c => !c.IsDeleted).FirstOrDefault(c => c.UserId == userId).Id;


            var cart = _unitOfWork.CartRepository.GetAll().Include(c => c.CartItems).ThenInclude(ci => ci.Product).FirstOrDefault(c => c.Id == cartId && !c.IsDeleted);


            var cartItem = cart.CartItems.FirstOrDefault(c => c.ProductId == productId);

            cart.CartItems.Remove(cartItem);

            var product = _unitOfWork.ProductRepository.GetAll().FirstOrDefault(c => c.Id.Equals(productId));


            cart.Total -= product.Price * cartItem.Quantity;

            _unitOfWork.SaveChanges();

            return true;

        }



        public CartDTO GetCart(int userId)
        {
            int cartId = _unitOfWork.CartRepository.GetAll().Where(c => !c.IsDeleted).FirstOrDefault(c => c.UserId == userId).Id;
            Cart cart = _unitOfWork.CartRepository.GetById(cartId, c => c.CartItems);
            var CartItems = new List<CartItemDTO>();

            foreach (var cartItem in cart.CartItems)
            {
                var product = _unitOfWork.ProductRepository.GetById(cartItem.ProductId, p => p.Artist);

                if (product.Amount < cartItem.Quantity)
                {
                    cartItem.Quantity = product.Amount;
                    CartItems.Add(new CartItemDTO(product.Id, product.Name, product.Artist.Name,
                         product.Amount, product.Price, product.ImageUrl, product.Amount));
                }
                else
                {
                    CartItems.Add(new CartItemDTO(product.Id, product.Name, product.Artist.Name,
                         cartItem.Quantity, product.Price, product.ImageUrl, product.Amount));
                }
            }
            _unitOfWork.SaveChanges();

            return new CartDTO(CartItems, cart.Total);


        }
    }
}
