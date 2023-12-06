using audio_ecommerce.Models.DTOs.Address;

namespace audio_ecommerce.Models.DTOs.User
{
    public class UserDTO
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public DateTime BirthDate { get; set; }

        public IEnumerable<AddressDTO> Addresses { get; set; }

        public UserDTO(string? name, string? surname, string email, string role, DateTime birthDate, IEnumerable<AddressDTO> addresses)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Role = role;
            BirthDate = birthDate;
            Addresses = addresses;
        }
    }
}
