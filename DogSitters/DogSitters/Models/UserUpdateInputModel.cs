namespace DogSitters.API.Models
{
    public class UserUpdateInputModel
    {
        string? Address;
        List<DogOutputModel>? Dogs;
        string? FirstName;
        bool IsVerified;
        string? LastName;
        string? Login;
        int MetroStationId;
        string? Password;
    }
}
