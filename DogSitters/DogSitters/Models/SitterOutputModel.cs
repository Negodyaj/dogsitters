namespace DogSitters.API.Models
{
    public class SitterOutputModel
    {
        List<ComplaintOutputModel>? Complaints;
        DateTime? DateOfBirth;
        string? FirstName;
        char? Gender;
        int Id;
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
