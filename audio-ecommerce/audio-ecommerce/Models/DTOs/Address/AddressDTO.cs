namespace audio_ecommerce.Models.DTOs.Address
{
    public class AddressDTO
    {


        public string Street { get; set; }


        public string City { get; set; }


        public string Country { get; set; }

        public string ZipCode { get; set; }


        public string PhoneNumber { get; set; }


        public bool IsShipping { get; set; }

        public bool IsBilling { get; set; }

        public AddressDTO(string street, string city, string country, string zipCode, string phoneNumber, bool isShipping, bool isBilling)
        {
            Street = street;
            City = city;
            Country = country;
            ZipCode = zipCode;
            PhoneNumber = phoneNumber;
            IsShipping = isShipping;
            IsBilling = isBilling;
        }
    }
}
