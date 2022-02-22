namespace DogSitters.API.Models
{
    public class DogOutputModel
    {
        public int Id { get; set; }
        public int BirthMonth { get; set; }
        public int BirthYear { get; set; }
        public string Breed { get; set; }
        public DataLayer.Gender Gender { get; set; }
        public bool IsBig { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
    }
}
