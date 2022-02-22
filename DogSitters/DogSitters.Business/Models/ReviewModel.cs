namespace DogSitters.Business.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public SitterModel Sitter { get; set; }
        public string Text { get; set; }
        public UserModel User { get; set; }
    }
}
