namespace DogSitters.API.Models
{
    public class UserInsertInputModel
    {
        string? Address;
        DateTime? DateOfBirth;
        List<DogOutputModel>? Dogs;
        string? FirstName;
        char? Gender;
        int Id;
        bool IsVerified = false;
        string? LastName;
        string? Login;
        int MetroStationId;
        string? Password;
    }
}
