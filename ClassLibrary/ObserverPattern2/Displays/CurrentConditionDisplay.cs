using ObserverPattern2.Interfaces;

namespace ObserverPattern2.Displays
{
    public class CurrentConditionDisplay : IObserver
    {
        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine("This is Current Conditions Display !");
            Console.WriteLine($"Current temp \t:\t {temp}");
            Console.WriteLine($"Current humidity \t:\t {humidity}");
            Console.WriteLine($"Current pressure \t:\t {pressure}");
        }
    }
}
