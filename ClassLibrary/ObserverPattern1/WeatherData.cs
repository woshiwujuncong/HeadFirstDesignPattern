using ObserverPattern1.Displays;

namespace ObserverPattern1
{
    public class WeatherData
    {
        private readonly CurrentConditionsDisplay _currentConditionsDisplay = new();
        private readonly StatisticsDisplay _statisticsDisplay = new();
        private readonly ForecastDisplay _forecastDisplay = new();

        public void MeasurementsChanged()
        {
            var temp = GetTemperature();
            var humidity = GetHumidity();
            var pressure = GetPressure();

            _currentConditionsDisplay.Update(temp, humidity, pressure);
            _statisticsDisplay.Update(temp, humidity, pressure);
            _forecastDisplay.Update(temp, humidity, pressure);
        }

        private static float GetPressure()
        {
            return WeatherGenerator.Instance.GetPressure();
        }

        private static float GetHumidity()
        {
            return WeatherGenerator.Instance.GetHumidity();
        }

        private static float GetTemperature()
        {
            return WeatherGenerator.Instance.GetTemperature();
        }
    }
}
