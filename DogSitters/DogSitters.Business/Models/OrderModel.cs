namespace DogSitters.Business.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DogModel Dog { get; set; }
        public SitterModel Sitter { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
        public UserModel User { get; set; }
    }
}
