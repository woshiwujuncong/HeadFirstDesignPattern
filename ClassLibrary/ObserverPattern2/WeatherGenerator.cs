namespace ObserverPattern2
{
    public class WeatherGenerator
    {
        public static readonly WeatherGenerator Instance;
        private static float _temp = 25;
        private static float _humidity = 60;
        private static float _pressure = 100;

        public Action<float, float, float>? WeatherUpdateEvent;

        static WeatherGenerator()
        {
            Instance = new WeatherGenerator();
        }

        private WeatherGenerator()
        {
            Task.Run(Work);
        }

        private void Work()
        {
            while (true)
            {
                var random = new Random();
                _temp += random.NextSingle() * random.Next(-1, 2);
                _humidity += random.NextSingle() * random.Next(-1, 2);
                _pressure += random.NextSingle() * random.Next(-1, 2);
                WeatherUpdateEvent?.Invoke(_temp, _humidity, _pressure);
                Thread.Sleep(5000);
            }
        }
    }
}
