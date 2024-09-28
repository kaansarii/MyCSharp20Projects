using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project15_GasPriceSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double dieselPrice = 0;
        double gasolinePrice = 0;
        double lpgPrice = 0;

        double gasAmout = 0;
        double totalPrice = 0;
        int count = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            gasAmout = Convert.ToDouble(txtGasAmount.Text);
            timer1.Start();
            timer1.Interval = 500;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = count.ToString();
            if (rdbGasoline.Checked)
            { 
                count++;
                if(count <= gasAmout)
                {
                    totalPrice += gasolinePrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                    progressBar1.Value  += 3;
                    if (progressBar1.Value == count)
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                    timer1.Stop();

                }
               
            }

            if (rdbDiesel.Checked)
            {
                count++;
                if (count <= gasAmout)
                {
                    totalPrice += dieselPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                    progressBar1.Value += 3;
                    if (progressBar1.Value == count)
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                    timer1.Stop();

                }

            }


            if (rdbLPG.Checked)
            {
                count++;
                if (count <= gasAmout)
                {
                    totalPrice += lpgPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                    progressBar1.Value += 3;
                    if (progressBar1.Value == count)
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                    timer1.Stop();

                }

            }

        }

        private async void Form1_Load(object sender, EventArgs e)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://akaryakit-fiyatlari.p.rapidapi.com/fuel/istanbul"),
            Headers =
        {
            { "x-rapidapi-key", "2746dba02fmsh977643c5a626a1ap18d1abjsn279e636d6159" },
            { "x-rapidapi-host", "akaryakit-fiyatlari.p.rapidapi.com" },
        },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            var json = JObject.Parse(body);
            var gasolineJsonValue = json["data"][16]["prices"][0]["benzin"];
            var dieselJsonValue = json["data"][16]["prices"][0]["motorin"];
            var lpgJsonValue = json["data"][16]["prices"][0]["lpg"];
            var stationName = json["data"][16]["prices"][0]["dagitici_firma"];

            // Kültürel ayarlarla birlikte string'i double'a çevir
            var cultureInfo = new CultureInfo("tr-TR");

            if (double.TryParse(gasolineJsonValue.ToString(), NumberStyles.Any, cultureInfo, out double gasolineParsed))
            {
                gasolinePrice = gasolineParsed;
            }
            if (double.TryParse(dieselJsonValue.ToString(), NumberStyles.Any, cultureInfo, out double dieselParsed))
            {
                dieselPrice = dieselParsed;
            }
            if (double.TryParse(lpgJsonValue.ToString(), NumberStyles.Any, cultureInfo, out double lpgParsed))
            {
                lpgPrice = lpgParsed;
            }

            txtStation.Text = stationName.ToString();
            txtGasolinePrice.Text = gasolinePrice.ToString("F2", cultureInfo);  // Formatlı yazdırma
            txtDieselPrice.Text = dieselPrice.ToString("F2", cultureInfo);
            txtLPGPrice.Text = lpgPrice.ToString("F2", cultureInfo);
        }
    }

}
}
