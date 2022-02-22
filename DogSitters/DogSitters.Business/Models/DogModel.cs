namespace DogSitters.Business.Models
{
    public class DogModel
    {
        public int Id { get; set; }
        public int BirthMonth { get; set; }
        public int BirthYear { get; set; }
        public string Breed { get; set; }
        public DataLayer.Gender Gender { get; set; }
        public bool IsBig { get; set; }
        public string Name { get; set; }
        public List<OrderModel> Orders { get; set; }
        public string Photo { get; set; }
        public UserModel User { get; set; }
    }
}
