namespace DogSitters.API.Models
{
    public class ReviewOutputModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}
