namespace ObserverPattern1.Displays
{
    public class ForecastDisplay : IDisplay
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
