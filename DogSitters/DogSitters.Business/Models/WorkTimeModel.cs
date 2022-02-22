namespace DogSitters.Business.Models
{
    public class WorkTimeModel
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public SitterModel Sitter { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
    }
}
