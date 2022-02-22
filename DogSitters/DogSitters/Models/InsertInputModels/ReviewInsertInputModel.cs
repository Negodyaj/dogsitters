namespace DogSitters.API.Models
{
    public class ReviewInsertInputModel
    {
        public int Rating { get; set; }
        public string Text { get; set; }
        public UserOutputModel User { get; set; }
    }
}
