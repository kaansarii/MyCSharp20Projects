using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_13WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/landon/EN"),
                Headers =
    {
        { "x-rapidapi-key", "2746dba02fmsh977643c5a626a1ap18d1abjsn279e636d6159" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);

                var fahrenheit = json["main"]["feels_like"].ToString();
                var ruzgar = json["wind"]["speed"].ToString();
                var nem = json["main"]["humidity"].ToString();

                lblFahrenheit.Text = fahrenheit;
                lblRuzgar.Text = ruzgar;
                lblNem.Text = nem;

                double celcius = (double.Parse(fahrenheit) - 32);
                double celciusValue = celcius / 1.8;
                lblCelcius.Text = celciusValue.ToString("0.00");




                var weatherCondition = json["weather"][0]["main"].ToString();
                // Switch-case bloğu: hava durumuna göre resim değiştirme
                switch (weatherCondition.ToLower())
                {
                    case "clear":
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Kaan Sari\Desktop\Udemy 20 Proje\MyUdemy20Projects\Project_13WeatherApp\Images\sun.png");

                        break;

                    case "clouds":
                        pictureBox1.Image = Image.FromFile(@"Images\cloud.png");
                        break;

                    case "rain":
                        pictureBox1.Image = Image.FromFile(@"Images\rain.png");
                        break;

                    case "snow":
                        pictureBox1.Image = Image.FromFile(@"Images\snow.png");
                        break;

                    case "thunderstorm":
                        pictureBox1.Image = Image.FromFile(@"Images\thunderstorm.png");
                        break;

                    case "drizzle":
                        pictureBox1.Image = Image.FromFile(@"Images\rain.png");
                        break;

                    case "mist":
                    case "fog":
                        pictureBox1.Image = Image.FromFile(@"Images\mist.png");
                        break;

                    default:
                        pictureBox1.Image = Image.FromFile(@"Images\black.png");
                        break;
                }
            }
        }
    }
}
