using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherAPI.Models;

string apiKey = "ea20d5b8700db72131450c6ec7313a37";
string cidade = "São Paulo";
string url = $"http://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={apiKey}&units=metric&lang=pt_br";

using (HttpClient client = new HttpClient())
{
    try
    {
        var resposta = await client.GetFromJsonAsync<WeatherResponse>(url);

        if (resposta != null)
        {
            Console.WriteLine($" Temperatura de {cidade}: {resposta.Main.Temp}C°, Humidade: {resposta.Main.Humidity}.");
        }
        else
        {
            Console.WriteLine("Resposta da API, dados nullo.");
        }

    } catch (Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }  
}