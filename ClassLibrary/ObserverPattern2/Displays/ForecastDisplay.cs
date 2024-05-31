using ObserverPattern2.Interfaces;

namespace ObserverPattern2.Displays
{
    public class ForecastDisplay : IObserver
    {
        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine("This is Forecast Display !");
            Console.WriteLine($"Forecast temp \t:\t {temp}");
            Console.WriteLine($"Forecast humidity \t:\t {humidity}");
            Console.WriteLine($"Forecast pressure \t:\t {pressure}");
        }
    }
}
