namespace DogSitters.API.Models
{
    public class WorkTimeOutputModel
    {
        public int Id { get; set; }
        public DataLayer.Day Day { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
    }
}
