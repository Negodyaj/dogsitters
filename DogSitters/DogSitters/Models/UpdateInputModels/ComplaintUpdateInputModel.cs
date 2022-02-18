namespace DogSitters.API.Models
{
    public class ComplaintUpdateInputModel
    {
        public bool IsSolved { get; set; }
        public string Text { get; set; }
        public bool IsWatched { get; set; }
    }
}
