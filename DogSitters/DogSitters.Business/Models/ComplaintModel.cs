namespace DogSitters.Business.Models
{
    public class ComplaintModel
    {
        public int Id { get; set; }
        public bool IsSolved { get; set; }
        public bool IsWatched { get; set; }
        public SitterModel Sitter { get; set; }
        public string Text { get; set; }
        public UserModel User { get; set; }
    }
}
