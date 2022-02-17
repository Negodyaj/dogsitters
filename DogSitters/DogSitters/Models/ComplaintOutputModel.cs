namespace DogSitters.API.Models
{
    public class ComplaintOutputModel
    {
        int Id;
        int UserId;
        int SitterId;
        bool IsSolved;
        string? Text;
        bool IsWatched;
    }
}
