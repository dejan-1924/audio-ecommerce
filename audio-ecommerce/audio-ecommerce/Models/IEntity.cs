namespace audio_ecommerce.Models
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
        bool IsDeleted { get; set; }

    }
}
