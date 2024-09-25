﻿using Newtonsoft.Json.Linq;
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

namespace Project8_RapidApiCurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            #region Dolar
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "2746dba02fmsh977643c5a626a1ap18d1abjsn279e636d6159" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var value = json["result"].ToString();
                lblDolar.Text =  value;
                Console.WriteLine(body);
            }

            #endregion


            #region Euro
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "2746dba02fmsh977643c5a626a1ap18d1abjsn279e636d6159" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var json2 = JObject.Parse(body2);
                var value2= json2["result"].ToString();
                lblEuro.Text =  value2;
                Console.WriteLine( body2);
            }

            #endregion

            #region Sterlin

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "2746dba02fmsh977643c5a626a1ap18d1abjsn279e636d6159" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var json3 = JObject.Parse(body3);
                var value3 = json3["result"].ToString();
                lblSterlin.Text = value3;
                Console.WriteLine( body3);
            }
            #endregion


            txtTotalPrice.Enabled = false;
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {

            decimal unitPrice = decimal.Parse(txtUniPrice.Text);
            decimal dolar = decimal.Parse(lblDolar.Text);
            decimal euro = decimal.Parse(lblEuro.Text);
            decimal sterlin = decimal.Parse(lblSterlin.Text);
            decimal total = 0;
            
            if(rdbDolar.Checked)
            {
                total = unitPrice * dolar;
            }

            if (rdbEuro.Checked)
            {
                total = unitPrice * euro;
            }

            if (rdbSterlin.Checked)
            {
                total = unitPrice * sterlin;
            }
            txtTotalPrice.Text = total.ToString();

        }
    }
}
