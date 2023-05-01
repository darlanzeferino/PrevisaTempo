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
using static Previsão_do_Tempo.WeatherInfo;


namespace Previsão_do_Tempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKei = "a03c1962941ed5a244d19521d5ab77d0";

        private void btn_search_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&lang=pt_br&appid={1}", TbCity.Text, APIKei);

                var json = web.DownloadString(url);
                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                pic_icon.ImageLocation = "http://openweathermap.org/img/w/" +  info.weather[0].icon + ".png";
                //lab_condition.Text = info.weather[0].main;
                lab_detail.Text = info.weather[0].description;
                lab_umidade.Text = info.main.humidity.ToString() + "%";
                double temp = info.main.temp;
                double celsius = temp - 273.15;
                lab_temp.Text = celsius.ToString() + "°C";
                lab_windspeed.Text = info.wind.speed.ToString() + " m/s";
                double minFar = info.main.temp_min;
                double mincel = minFar - 273.15;
                lab_min.Text = mincel.ToString() + "°C";
                double maxFar = info.main.temp_max;
                double maxCel = maxFar - 273.15;
                lab_max.Text = maxCel.ToString() + "°C";
                lab_lon.Text = info.coord.lon.ToString();
                lab_lat.Text = info.coord.lat.ToString();

                //lab_pressure.Text = info.main.pressure.ToString();
            }
        }
    }
}
