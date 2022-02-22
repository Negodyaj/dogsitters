namespace DogSitters.Business.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public AddressModel Address { get; set; }
        public List<ComplaintModel> Complaints { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<DogModel> Dogs { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public DataLayer.Gender Gender { get; set; } 
        public bool IsVerified { get; set; }
        public string LastName { get; set; }
        public List<MetroStationModel> MetroStations { get; set; }
        public List<OrderModel> Orders { get; set; }
        public string PhoneNumber { get; set; }
        public List<ReviewModel> Reviews { get; set; }
    }
}
