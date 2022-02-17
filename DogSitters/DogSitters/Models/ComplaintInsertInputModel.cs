namespace DogSitters.API.Models
{
    public class ComplaintInsertInputModel
    {
        int Id;
        int UserId;
        int SitterId;
        bool IsSolved = false;
        string? Text;
        bool IsWatched = false;
    }
}
