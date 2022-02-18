namespace DogSitters.API.Models
{
    public class OrderUpdateInputModel
    {
        public Address Address { get; set; }
        public List<MetroStation> MetroStations { get; set; }
        public int SitterId { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
    }
}
