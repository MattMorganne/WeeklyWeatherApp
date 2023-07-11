
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using WeeklyWeatherApp.Views;

namespace WeeklyWeatherApp
{
    public partial class MainPage : ContentPage
    {
        private List<string> dates;
        private List<string> dates2;

        public String CurrentDate => DateTime.UtcNow.ToString("dddd, dd MMMM");
        public String Day => DateTime.Now.ToString("dddd");


        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            DateLabel.Text = "Today's date is " + CurrentDate;

            GetTemperatureData();



        }

        private async void GetTemperatureData()
        {
            getDates2();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/forecast.json?q=-25.7459277%2C28.1879101&days=7"),
                Headers =
    {
        { "X-RapidAPI-Key", "090bd25ff0mshd2255515b35f640p160560jsn7b32924461f6" },
        { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                if (weatherData != null)
                {
                    getDates();
                    var forecastDayDataList = weatherData.Forecast.Forecastday;
                    day1.Text = dates[0] + " temperature " + forecastDayDataList[0].Day.Mintemp_c + " - " + forecastDayDataList[0].Day.Maxtemp_c;
                    day2.Text = dates[1] + " temperature " + forecastDayDataList[1].Day.Mintemp_c + " - " + forecastDayDataList[1].Day.Maxtemp_c;
                    day3.Text = dates[2] + " temperature " + forecastDayDataList[2].Day.Mintemp_c + " - " + forecastDayDataList[2].Day.Maxtemp_c;

                }
            }

            // second request
            client = new HttpClient();
                  request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/forecast.json?q=-25.7459277%2C28.1879101&days=3&dt="+ dates2[3]),
                    Headers =
                {
                    { "X-RapidAPI-Key", "090bd25ff0mshd2255515b35f640p160560jsn7b32924461f6" },
                    { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
                },
                  };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                if (weatherData != null)
                {
              
                    var forecastDayDataList = weatherData.Forecast.Forecastday;
                    day4.Text = dates[3] + " temperature " + forecastDayDataList[0].Day.Mintemp_c + " - " + forecastDayDataList[0].Day.Maxtemp_c;
                   

                }
            }
            //third request

            client = new HttpClient();
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/forecast.json?q=-25.7459277%2C28.1879101&days=3&dt=" + dates2[4]),
                Headers =
                {
                    { "X-RapidAPI-Key", "090bd25ff0mshd2255515b35f640p160560jsn7b32924461f6" },
                    { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                if (weatherData != null)
                {

                    var forecastDayDataList = weatherData.Forecast.Forecastday;
                    day5.Text = dates[4] + " temperature " + forecastDayDataList[0].Day.Mintemp_c + " - " + forecastDayDataList[0].Day.Maxtemp_c;


                }
            }

            // 4


            client = new HttpClient();
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/forecast.json?q=-25.7459277%2C28.1879101&days=3&dt=" + dates2[5]),
                Headers =
                {
                    { "X-RapidAPI-Key", "090bd25ff0mshd2255515b35f640p160560jsn7b32924461f6" },
                    { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                if (weatherData != null)
                {

                    var forecastDayDataList = weatherData.Forecast.Forecastday;
                    day6.Text = dates[5] + " temperature " + forecastDayDataList[0].Day.Mintemp_c + " - " + forecastDayDataList[0].Day.Maxtemp_c;


                }
            }


            // 6


            client = new HttpClient();
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/forecast.json?q=-25.7459277%2C28.1879101&days=3&dt=" + dates2[6]),
                Headers =
                {
                    { "X-RapidAPI-Key", "090bd25ff0mshd2255515b35f640p160560jsn7b32924461f6" },
                    { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                if (weatherData != null)
                {

                    var forecastDayDataList = weatherData.Forecast.Forecastday;
                    day7.Text = dates[6] + " temperature " + forecastDayDataList[0].Day.Mintemp_c + " - " + forecastDayDataList[0].Day.Maxtemp_c;


                }
            }





        } 


    

 
        public List<String> getDates()
        {
            dates = new List<String>();
            DateTime dateNow = DateTime.Now;
            for (int i = 0; i < 7; i++)
            {
                dates.Add(DateTime.Now.AddDays(i).ToString("dddd, dd MMMM"));
            }
            return dates;
        }

        public List<String> getDates2()
        {
            dates2 = new List<String>();
            DateTime dateNow = DateTime.Now;
            for (int i = 0; i < 7; i++)
            {
                dates2.Add(DateTime.Now.AddDays(i).ToString("yyyy-MM-dd").Trim());
            }
            return dates2;
        }
        

        private async void onDayCliclk(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string selectedDay = clickedButton.Text;

            await Navigation.PushAsync(new DetailsPage { SelectedDay = selectedDay });


        }
    }
}
