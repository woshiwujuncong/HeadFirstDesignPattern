namespace ObserverPattern1
{
    public class WeatherGenerator
    {
        public static readonly WeatherGenerator Instance;
        private static float _temp = 25;
        private static float _humidity = 60;
        private static float _pressure = 100;

        static WeatherGenerator()
        {
            Instance = new WeatherGenerator();
        }

        private WeatherGenerator()
        {
            Task.Run(Work);
        }

        private static void Work()
        {
            while (true)
            {
                var random = new Random();
                _temp += random.NextSingle() * random.Next(-1, 2);
                _humidity += random.NextSingle() * random.Next(-1, 2);
                _pressure += random.NextSingle() * random.Next(-1, 2);
                Thread.Sleep(5000);
            }
        }

        public float GetTemperature()
        {
            return _temp;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }
    }
}
