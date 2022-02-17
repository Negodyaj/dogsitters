namespace DogSitters.API.Models
{
    public class ReviewInsertInputModel
    {
        int Id;
        int UserId;
        int SitterId;
        string? Text;
        decimal Rating;
    }
}
