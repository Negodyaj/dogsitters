namespace DogSitters.API.Models
{
    public class UserInsertInputModel
    {
        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<DogInsertInputModel> Dogs { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public DataLayer.Gender Gender { get; set; }
        public string LastName { get; set; }
        public List<MetroStation> MetroStations { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
