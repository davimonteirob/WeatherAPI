using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherAPI.Models;

string apiKey = "ea20d5b8700db72131450c6ec7313a37";
string cidade = "Paulista";
string url = $"http://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={apiKey}&units=metric&lang=pt_br";

using (HttpClient client = new HttpClient())
{
    try
    {
        var resposta = await client.GetFromJsonAsync<WeatherResponse>(url);

    } catch (Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }  
}