namespace DogSitters.API.Models
{
    public class ComplaintOutputModel
    {
        public int Id { get; set; }
        public bool IsSolved { get; set; }
        public bool IsWatched { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
    }
}
