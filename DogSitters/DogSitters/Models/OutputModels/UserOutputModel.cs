namespace DogSitters.API.Models
{
    public class UserOutputModel
    {
        public int Id { get; set; }
        public AddressOutputModel Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<DogOutputModel> Dogs { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public DataLayer.Gender Gender { get; set; }
        public bool IsVerified { get; set; }
        public string LastName { get; set; }
        public List<int> MetroStations { get; set; }
        public string PhoneNumber { get; set; }
    }
}
