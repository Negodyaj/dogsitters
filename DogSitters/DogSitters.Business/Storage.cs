namespace DogSitters.Business
{
    public sealed class Storage
    {
        private Storage() { }

        private static Storage _instance;

        public static Storage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Storage();
            }

            return _instance;
        }
    }
}
