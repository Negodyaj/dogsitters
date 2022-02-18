namespace DogSitters.API.Models
{
    public class UserUpdateInputModel
    {
        public Address Address { get; set; }
        List<DogUpdateInputModel> Dogs { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public bool IsVerified { get; set; }
        public string LastName { get; set; }
        public List<MetroStation> MetroStations { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
