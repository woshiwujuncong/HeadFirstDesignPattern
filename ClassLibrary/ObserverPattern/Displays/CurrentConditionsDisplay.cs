namespace ObserverPattern1.Displays
{
    public class CurrentConditionsDisplay : IDisplay
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
