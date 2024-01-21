using RestSharp;
using System.Diagnostics;
using System.Text.Json;
using WeatherWebApp.DomainServices.Base;
using WeatherWebApp.Model.Api;
using WeatherWebApp.Model.Api.DTO;

namespace WeatherWebApp.DomainServices
{
    public class TownService: ITownService
    {
        private readonly RestClient _restClient;
        private readonly string _baseUrl;
        private readonly ITranslatorService _translatorService;
        public TownService(IConfiguration configuration, ITranslatorService translatorService)
        {
            _baseUrl = configuration.GetValue<string>("PublicDataUrl");
            if (string.IsNullOrWhiteSpace(_baseUrl))
            {
                throw new ArgumentNullException();
            }
            _restClient = new RestClient(_baseUrl);
            _translatorService = translatorService;
        }

        public List<SimpleData> GetWeatherForTowns(List<DtoTown> towns)
        {
            var request = new RestRequest($"/synop", Method.Get);
            try
            {
                var result = _restClient.Execute<List<SynopticData>>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var listOfForecast = JsonSerializer.Deserialize<List<SynopticData>>(result.Content);
                    if (listOfForecast == null)
                        return null;
                    //_translatorService.ToSimplePolish
                    var dataList = listOfForecast
                        .Where(x => towns.Any(town => town.Name == x.stacja))
                        .Select(x => new SimpleData
                        {
                            Name = x.stacja,
                            Value = x.temperatura
                        }).ToList();
                    
                    return dataList;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }


        public List<SimpleData> GetPressureForTowns(List<DtoTown> towns)
        {
            var request = new RestRequest($"/synop", Method.Get);
            try
            {
                var result = _restClient.Execute<List<SynopticData>>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var listOfForecast = JsonSerializer.Deserialize<List<SynopticData>>(result.Content);
                    if (listOfForecast == null)
                        return null;
                    //_translatorService.ToSimplePolish
                    var dataList = listOfForecast
                        .Where(x => towns.Any(town => town.Name == x.stacja))
                        .Select(x => new SimpleData
                        {
                            Name = x.stacja,
                            Value = x.cisnienie
                        }).ToList();

                    return dataList;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

        public List<SimpleData> GetHumidityForTowns(List<DtoTown> towns)
        {
            var request = new RestRequest($"/synop", Method.Get);
            try
            {
                var result = _restClient.Execute<List<SynopticData>>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var listOfForecast = JsonSerializer.Deserialize<List<SynopticData>>(result.Content);
                    if (listOfForecast == null)
                        return null;
                    //_translatorService.ToSimplePolish
                    var dataList = listOfForecast
                        .Where(x => towns.Any(town => town.Name == x.stacja))
                        .Select(x => new SimpleData
                        {
                            Name = x.stacja,
                            Value = x.wilgotnosc_wzgledna
                        }).ToList();

                    return dataList;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }


        public List<SynopticData> GetSynopticData()
        {
            var request = new RestRequest($"/synop", Method.Get);
            try
            {
                var result = _restClient.Execute<List<SynopticData>>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var listOfForecast = JsonSerializer.Deserialize<List<SynopticData>>(result.Content);
                    if (listOfForecast == null)
                        return null;

                    return listOfForecast;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

        public List<string> GetTownsList()
        {
            var request = new RestRequest($"/synop", Method.Get);

            try
            {
                var result = _restClient.Execute<List<SynopticData>>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var listOfForecast = JsonSerializer.Deserialize<List<SynopticData>>(result.Content);
                    if (listOfForecast == null)
                        return null;

                    var listOfTownNames = new List<string>();
                    foreach (var item in listOfForecast)
                    {
                        listOfTownNames.Add(item.stacja);
                    }

                    return listOfTownNames;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

        public TownInfo GetTown(string normalizedName)
        {
            var request = new RestRequest($"/synop/station/{normalizedName}", Method.Get);

            try
            {
                var result = _restClient.Execute<SynopticData>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var townInformation = JsonSerializer.Deserialize<SynopticData>(result.Content);
                    if (townInformation == null)
                        return null;

                    var resultx = new TownInfo();
                    resultx.stacja = townInformation.stacja;
                    resultx.cisnienie =     townInformation.cisnienie;
                    resultx.data_pomiaru = townInformation.data_pomiaru;
                    resultx.temperatura = townInformation.temperatura;
                    resultx.godzina_pomiaru = townInformation.godzina_pomiaru;
                    return resultx;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

    }
}
