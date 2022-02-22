namespace DogSitters.API
{
    public enum Day
    {
        Monday = 0,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class WorkTime
    {
        public Day Day { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
    }
}
