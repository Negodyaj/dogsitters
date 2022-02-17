namespace DogSitters.API.Models
{
    public class OrderUpdateInputModel
    {
        string? Address;
        int DogId;
        DateTime? EndTime;
        int MetroStationId;
        int SitterId;
        DateTime? StartTime;
    }
}
