namespace DogSitters.Business.Models
{
    internal class WorkTimeModel
    {
        public int Day { get; set; }
        public int Id { get; set; }
        public SitterModel Sitter { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
    }
}
