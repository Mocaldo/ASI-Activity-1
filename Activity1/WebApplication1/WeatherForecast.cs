using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int PostalCode { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

 public class WeatherInfo
    {
    public City city { get; set; }
    public List<List> list { get; set; }
}

public class City
{
    public string name { get; set; }
    public string country { get; set; }
}

public class Temp
{
    public double day { get; set; }
    public double min { get; set; }
    public double max { get; set; }
    public double night { get; set; }
}

public class Weather
{
    public string description { get; set; }
    public string icon { get; set; }
}

public class List
{
    public Temp temp { get; set; }
    public int humidity { get; set; }
    public List<Weather> weather { get; set; }
}
}
