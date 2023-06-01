using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        string apikey = "c3d81f7912def564a22b248a0649fa49";

        private void search_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", input.Text, apikey);
                var json = web.DownloadString(url);
                WeatherInformation.root Info = JsonConvert.DeserializeObject<WeatherInformation.root>(json);
                condition.Text = Info.weather[0].main;
                details.Text = Info.weather[0].description;
                na.Text = Info.main.temp_min.ToString();
                na2.Text = Info.main.temp_max.ToString();
                na3.Text = Info.wind.speed.ToString();
                na4.Text = Info.main.humidity.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.time.Text = datetime.ToString();
        }
    }
}
