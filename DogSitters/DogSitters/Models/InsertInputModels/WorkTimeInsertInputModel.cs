namespace DogSitters.API.Models
{
    public class WorkTimeInsertInputModel
    {
        public DataLayer.Day Day { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
    }
}
