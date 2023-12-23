using audio_ecommerce.Models;
using audio_ecommerce.Repositories;
using audio_ecommerce.SupportClasses.JWT;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace audio_ecommerce.Services.impl
{
    public class OrderService : IOrderService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IJWTGenerator _jwtGenerator;


        public OrderService(IUnitOfWork unitOfWork, IMapper mapper, IJWTGenerator jwtGenerator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _jwtGenerator = jwtGenerator;
        }


        public int Create(int userId)
        {


            User user = _unitOfWork.UserRepository.GetById(userId);

            Cart cart = _unitOfWork.CartRepository.GetAll().Include(c => c.CartItems).Where(c => !c.IsDeleted).FirstOrDefault(c => c.UserId == userId);



            var order = new Order
            {
                OrderDate = DateTime.Now,
                User = user,
                OrderItems = new List<OrderItem>()
            };


            foreach (var item in cart.CartItems)
            {

                Product product = _unitOfWork.ProductRepository.GetById(item.ProductId, a => a.Artist);

                if (item.Quantity <= product.Amount)
                {

                    var orderItem = new OrderItem
                    {
                        Product = product,
                        Quantity = item.Quantity,

                    };

                    order.OrderItems.Add(orderItem);

                }
                else
                {
                    string message = product.Artist.Name + " - " + product.Name + " is not available in selected amount. There is only " + product.Amount + " copies left in stock.";
                    throw new InvalidOperationException(message);
                }
            }

            _unitOfWork.OrderRepository.Create(order);

            foreach (OrderItem orderItem in order.OrderItems)
            {
                Product product = _unitOfWork.ProductRepository.GetById(orderItem.ProductId);
                product.Amount = product.Amount - orderItem.Quantity;
            }

            _unitOfWork.CartRepository.Delete(cart);

            Cart newCart = new Cart(user);

            _unitOfWork.CartRepository.Create(newCart);


            _unitOfWork.SaveChanges();

            return order.Id;

        }
    }
}
