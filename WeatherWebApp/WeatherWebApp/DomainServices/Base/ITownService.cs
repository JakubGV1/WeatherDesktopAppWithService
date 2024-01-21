using WeatherWebApp.Model.Api;
using WeatherWebApp.Model.Api.DTO;

namespace WeatherWebApp.DomainServices.Base
{
    public interface ITownService
    {
        List<string> GetTownsList();
        TownInfo GetTown(string normalizedName);
        List<SynopticData> GetSynopticData();
        List<SimpleData> GetWeatherForTowns(List<DtoTown> towns);
        List<SimpleData> GetPressureForTowns(List<DtoTown> towns);
        List<SimpleData> GetHumidityForTowns(List<DtoTown> towns);
    }
}
