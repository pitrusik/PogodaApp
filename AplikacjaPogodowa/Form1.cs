using System;
using System.Windows.Forms;
using WeatherApp.Models;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private WeatherService _weatherService;

        public Form1()
        {
            InitializeComponent();
            _weatherService = new WeatherService();
            this.AcceptButton = GetWeatherButton;
        }

        private async void GetWeatherButton_Click(object sender, EventArgs e)
        {
            try
            {
                WeatherService weatherService = new WeatherService();
                WeatherInfo weatherInfo = await weatherService.GetWeatherAsync(CityTextBox.Text);
                TempTextBox.Text = $"Temperatura: {weatherInfo.Main.Temp} °C";
                WindTextBox.Text = $"Wiatr: {weatherInfo.Wind.Speed} m/s";
                HumidityTextBox.Text = $"Wilgotność: {weatherInfo.Main.Humidity} %";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nie udało się pobrać danych pogodowych: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HumidityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WindTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}