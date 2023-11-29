namespace audio_ecommerce.Models.DTOs.User
{
    public class JWTokenWrapper
    {
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
