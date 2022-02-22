namespace DogSitters.Business.Models
{
    public class SitterModel
    {
        public int Id { get; set; }
        public List <ComplaintModel> Complaints { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public DataLayer.Gender Gender { get; set; }
        public string Info { get; set; }
        public bool IsApproved { get; set; }
        public string LastName { get; set; }
        public List <MetroStationModel> MetroStations { get; set; }
        public List<OrderModel> Orders { get; set; }
        public string Passport { get; set; }
        public string PhoneNumber { get; set; }
        public string Photo { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public List<ReviewModel> Reviews { get; set; }
        public List<WorkTimeModel> WorkTime { get; set; }
    }
}
