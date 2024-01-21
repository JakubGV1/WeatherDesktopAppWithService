using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppClient.Models;
using WeatherAppClient.Models.DTO;

namespace WeatherAppClient.DomainServices.Base
{
    public interface IWeatherService
    {
        bool PingAuth();
        List<WeatherForecastEntry> WeatherFullInformations();
        TownInfo WeatherForSpecificCity(string city);
        List<SimpleData> GetWeatherForMultipleCities(List<DtoTown> towns);
        List<SimpleData> GetHumidityForMultipleCities(List<DtoTown> towns);
        List<SimpleData> GetPressureForMultipleCities(List<DtoTown> towns);
        List<string> ListOfTowns();
    }
}
