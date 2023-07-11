﻿using Newtonsoft.Json;

// Define classes to represent the weather data structure
public class WeatherData
{
    public ForecastData Forecast { get; set; }
}

public class ForecastData
{
    public List<ForecastDayData> Forecastday { get; set; }
}

public class ForecastDayData
{
    public string Date { get; set; }
    public long Date_epoch { get; set; }
    public DayData Day { get; set; }
}

public class DayData
{
    public double Maxtemp_c { get; set; }
    public double Maxtemp_f { get; set; }
    public double Mintemp_c { get; set; }
    public double Mintemp_f { get; set; }
    public double Avgtemp_c { get; set; }
    public double Avgtemp_f { get; set; }
    public double Maxwind_mph { get; set; }
    public double Maxwind_kph { get; set; }
    public double Totalprecip_mm { get; set; }
    public double Totalprecip_in { get; set; }
    public double Totalsnow_cm { get; set; }
    public double Avgvis_km { get; set; }
    public double Avgvis_miles { get; set; }
    public double Avghumidity { get; set; }  
    public int Daily_will_it_rain { get; set; }
    public int Daily_chance_of_rain { get; set; }
    public int Daily_will_it_snow { get; set; }
    public int Daily_chance_of_snow { get; set; }
}

}