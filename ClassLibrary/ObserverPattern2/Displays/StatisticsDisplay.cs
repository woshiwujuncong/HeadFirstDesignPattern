using ObserverPattern2.Interfaces;

namespace ObserverPattern2.Displays
{
    public class StatisticsDisplay : IObserver
    {
        private int _count = 0;
        private float _totalTemp = 0;
        private float _totalHumidity = 0;
        private float _totalPressure = 0;

        public void Update(float temp, float humidity, float pressure)
        {
            _count++;
            _totalTemp += temp;
            _totalHumidity += humidity;
            _totalPressure += pressure;

            Console.WriteLine("This is Statistic Display !");
            Console.WriteLine($"Average temp \t:\t {_totalTemp / _count}");
            Console.WriteLine($"Average humidity \t:\t {_totalHumidity / _count}");
            Console.WriteLine($"Average pressure \t:\t {_totalPressure / _count}");
        }
    }
}
