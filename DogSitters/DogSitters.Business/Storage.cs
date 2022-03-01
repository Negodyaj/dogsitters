namespace DogSitters.Business
{
    public sealed class Storage
    {
        private static Storage _instance;

        private Storage() { }

        public static Storage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Storage();
            }

            return _instance;
        }

        public List<Models.AddressModel> Addresses { get; set; }
        public List<Models.ComplaintModel> Complaints { get; set; }
        public List<Models.DogModel> Dogs { get; set; }
        public List<Models.MetroStationModel> MetroStations { get; set; }
        public List<Models.OrderModel> Orders { get; set; }
        public List<Models.ReviewModel> Reviews { get; set; }
        public List<Models.SitterModel> Sitters { get; set; }
        public List<Models.UserModel> Users { get; set; }
        public List<Models.WorkTimeModel> WorkTimes { get; set; }
    }
}
