namespace DogSitters.API.Models
{
    public class SitterUpdateInputModel
    {
        List<ComplaintOutputModel>? Complaints;
        string? FirstName;
        string? Info;
        bool IsApproved;
        string? LastName;
        List<int>? MetroStationsIds;
        string? Passport;
        string? PhotoLink;
        decimal Price;
        List<ReviewOutputModel>? Reviews;
        DateTime? WorkTimeEnd;
        DateTime? WorkTimeStart;
    }
}
