namespace DogSitters.API.Models
{
    public class SitterInsertInputModel
    {
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public DataLayer.Gender Gender { get; set; }
        public string Info { get; set; }
        public string LastName { get; set; }
        public List<int> MetroStations { get; set; }
        public string Passport { get; set; }
        public string PhoneNumber { get; set; }
        public string Photo { get; set; }
        public decimal Price { get; set; }
        public List<WorkTimeInsertInputModel> WorkTime { get; set; }
    }
}
