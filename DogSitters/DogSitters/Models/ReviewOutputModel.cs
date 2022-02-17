namespace DogSitters.API.Models
{
    public class ReviewOutputModel
    {
        int Id;
        int UserId;
        int SitterId;
        string? Text;
        decimal Rating;
    }
}
