namespace DogSitters.API.Models
{
    public class SitterOutputModel
    {
        public List<ComplaintOutputModel> Complaints { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public DataLayer.Gender Gender { get; set; }
        public int Id { get; set; }
        public string Info { get; set; }
        public bool IsApproved { get; set; }
        public string LastName { get; set; }
        public List<MetroStation> MetroStations { get; set; }
        public string Passport { get; set; }
        public string PhoneNumber { get; set; }
        public string Photo { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public List<ReviewOutputModel> Reviews { get; set; }
        public List<WorkTime> WorkTime { get; set; }
    }
}
