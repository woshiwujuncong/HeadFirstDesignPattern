using ObserverPattern2.Interfaces;

namespace ObserverPattern2
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers = [];

        private float _temp;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            WeatherGenerator.Instance.WeatherUpdateEvent += UpdateWeather;
        }

        private void UpdateWeather(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(observer => observer.Update(_temp, _humidity, _pressure));
        }
    }
}
