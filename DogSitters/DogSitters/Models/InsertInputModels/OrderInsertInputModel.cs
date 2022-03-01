namespace DogSitters.API.Models
{
    public class OrderInsertInputModel
    {
        public int DogId { get; set; }
        public int SitterId { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
        public int UserId { get; set; }
    }
}
