using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.Product;
using audio_ecommerce.Repositories;
using audio_ecommerce.SupportClasses.JWT;
using AutoMapper;

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


        public int Create(List<ProductCartDTO> items, int id)
        {


            User user = _unitOfWork.UserRepository.GetById(id);
            var order = new Order
            {
                OrderDate = DateTime.Now,
                User = user,
                OrderItems = new List<OrderItem>()
            };


            foreach (var item in items)
            {
                if (item.Amount < _unitOfWork.ProductRepository.GetById(item.Id).Amount)
                {

                    Product product = _unitOfWork.ProductRepository.GetById(item.Id);
                    var orderItem = new OrderItem
                    {
                        Product = product,
                        Quantity = item.Amount,

                    };

                    order.OrderItems.Add(orderItem);

                }
                else
                {
                    throw new InvalidOperationException("Product amount not valid!");
                }
            }

            _unitOfWork.OrderRepository.Create(order);

            foreach (OrderItem orderItem in order.OrderItems)
            {
                Product product = _unitOfWork.ProductRepository.GetById(orderItem.ProductId);
                product.Amount = product.Amount - orderItem.Quantity;
            }


            _unitOfWork.SaveChanges();

            return order.Id;

        }
    }
}
