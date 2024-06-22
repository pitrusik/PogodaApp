namespace WeatherApp.Models
{
    public class WeatherInfo
    {
        public Main Main { get; set; }
        public Wind Wind { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
    }

}