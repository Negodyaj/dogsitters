namespace DogSitters.API.Models
{
    public class ReviewInsertInputModel
    {
        public int UserId { get; set; }
        string Text { get; set; }
        int Rating { get; set; }
    }
}
