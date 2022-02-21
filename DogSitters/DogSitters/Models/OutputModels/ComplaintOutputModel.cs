namespace DogSitters.API.Models
{
    public class ComplaintOutputModel
    {
        public int Id { get; set; }
        public bool IsSolved { get; set; }
        public string Text { get; set; }
        public bool IsWatched { get; set; }
    }
}
