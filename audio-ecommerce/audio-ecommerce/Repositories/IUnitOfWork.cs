using audio_ecommerce.Models;

namespace audio_ecommerce.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<Product> ProductRepository { get; }
        IGenericRepository<Order> OrderRepository { get; }
        IGenericRepository<Address> AddressRepository { get; }
        IGenericRepository<OrderItem> OrderItemRepository { get; }
        IGenericRepository<Genre> GenreRepository { get; }

        IGenericRepository<Artist> ArtistRepository { get; }
        Task SaveChanges();
    }
}
