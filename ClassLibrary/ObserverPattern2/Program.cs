using ObserverPattern2;
using ObserverPattern2.Displays;
using ObserverPattern2.Interfaces;

ISubject subject = new WeatherData();

IObserver observer1 = new CurrentConditionDisplay();
IObserver observer2 = new ForecastDisplay();
IObserver observer3 = new StatisticsDisplay();

subject.RegisterObserver(observer1);
subject.RegisterObserver(observer2);
subject.RegisterObserver(observer3);

Thread.Sleep(14000);

subject.RemoveObserver(observer1);
subject.RemoveObserver(observer2);

Console.ReadLine();