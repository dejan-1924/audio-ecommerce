using audio_ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace audio_ecommerce.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IGenericRepository<User> _userRepository;
        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<Genre> _genreRepository;
        private IGenericRepository<Artist> _artistRepository;
        private IGenericRepository<Order> _orderRepository;
        private IGenericRepository<OrderItem> _orderItemRepository;
        private IGenericRepository<Address> _addressRepository;


        private DbContext _dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }



        public IGenericRepository<User> UserRepository
        {
            get
            {
                _userRepository ??= new GenericRepository<User>(_dbContext);
                return _userRepository;
            }
        }

        public IGenericRepository<Artist> ArtistRepository
        {
            get
            {
                _artistRepository ??= new GenericRepository<Artist>(_dbContext);
                return _artistRepository;
            }
        }

        public IGenericRepository<Product> ProductRepository
        {
            get
            {
                _productRepository ??= new GenericRepository<Product>(_dbContext);
                return _productRepository;
            }
        }

        public IGenericRepository<Order> OrderRepository
        {
            get
            {
                _orderRepository ??= new GenericRepository<Order>(_dbContext);
                return _orderRepository;
            }
        }

        public IGenericRepository<OrderItem> OrderItemRepository
        {
            get
            {
                _orderItemRepository ??= new GenericRepository<OrderItem>(_dbContext);
                return _orderItemRepository;
            }
        }

        public IGenericRepository<Genre> GenreRepository
        {
            get
            {
                _genreRepository ??= new GenericRepository<Genre>(_dbContext);
                return _genreRepository;
            }
        }

        public IGenericRepository<Address> AddressRepository
        {
            get
            {
                _addressRepository ??= new GenericRepository<Address>(_dbContext);
                return _addressRepository;
            }
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
