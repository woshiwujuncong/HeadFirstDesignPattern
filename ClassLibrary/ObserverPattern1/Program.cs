using ObserverPattern1;

var wd = new WeatherData();

while (true)
{
    wd.MeasurementsChanged();
    Thread.Sleep(1000);
}
