namespace WeatherApp.Models
{
    public class WeatherInfo
    {
        public Main Main { get; set; }
        public Wiatr Wind { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class Wiatr
    {
        public double Speed { get; set; }
    }

}