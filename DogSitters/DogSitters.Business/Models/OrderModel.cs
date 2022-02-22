namespace DogSitters.Business.Models
{
    internal class OrderModel
    {
        public DogModel Dog { get; set; }
        public int Id { get; set; }
        public SitterModel Sitter { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
        public UserModel User { get; set; }
    }
}
