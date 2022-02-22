namespace DogSitters.API.Models
{
    public class OrderOutputModel
    {
        public int Id { get; set; }
        public DogOutputModel Dog { get; set; }
        public SitterOutputModel Sitter { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
        public UserOutputModel User { get; set; }
        
    }
}
