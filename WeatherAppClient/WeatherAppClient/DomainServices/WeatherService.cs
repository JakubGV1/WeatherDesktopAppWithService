using AutoMapper.Configuration;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using WeatherAppClient.DomainServices.Base;
using WeatherAppClient.Models;
using WeatherAppClient.Models.DTO;

namespace WeatherAppClient.DomainServices
{
    public class WeatherService : IWeatherService
    {
        private readonly RestClient _restClient;
        private readonly string _baseUrl = Properties.Settings.Default.BaseUrl;
        private readonly string _baseController = Properties.Settings.Default.WeatherController;

        public WeatherService()
        {
            _restClient = new RestClient(_baseUrl);
        }

        public bool PingAuth()
        {
            var request = new RestRequest($"{_baseUrl}{_baseController}/ping", Method.Get);
            try
            {
                var result = _restClient.Execute(request);
                return result.IsSuccessful && !string.IsNullOrEmpty(result.Content);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return false;
        }

        public List<string> ListOfTowns()
        {
            var request = new RestRequest($"{_baseUrl}{_baseController}/TownList", Method.Get);
            try
            {
                request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
                var result = _restClient.Execute<List<string>>(request);
                if(result.IsSuccessful && !string.IsNullOrEmpty(result.Content))
                {
                    return result.Data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

        public List<WeatherForecastEntry> WeatherFullInformations()
        {
            var request = new RestRequest($"{_baseUrl}{_baseController}/AllTowns", Method.Get);

            try
            {
                request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
                var result = _restClient.Execute<List<WeatherForecastEntry>>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var listForecast = System.Text.Json.JsonSerializer.Deserialize<List<WeatherForecastEntry>>(result.Content);
                    return listForecast;
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

        public TownInfo WeatherForSpecificCity(string city)
        {
            var request = new RestRequest($"{_baseUrl}{_baseController}/Town", Method.Get);

            var cityName = Uri.EscapeDataString(city);

            request.AddHeader("CityName", cityName);
            request.AddHeader("client-token", Properties.Settings.Default.ClientToken);

            try
            {
                request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
                var result = _restClient.Execute<TownInfo>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var forecastForCity = System.Text.Json.JsonSerializer.Deserialize<TownInfo>(result.Content);
                    return forecastForCity;
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
        
        public List<SimpleData> GetWeatherForMultipleCities(List<DtoTown> towns)
        {
            var request = new RestRequest($"{_baseUrl}{_baseController}/TownsWeather", Method.Post);
            request.AddJsonBody(towns);
            try
            {
                request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
                var result = _restClient.Execute<List<SimpleData>>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                 
                    var jsonSerializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };

                    var listForecast = JsonConvert.DeserializeObject<List<SimpleData>>(result.Content, jsonSerializerSettings);

                    return listForecast;
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


        public List<SimpleData> GetHumidityForMultipleCities(List<DtoTown> towns)
        {
            var request = new RestRequest($"{_baseUrl}{_baseController}/TownsHumidity", Method.Post);
            request.AddJsonBody(towns);
            try
            {
                request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
                var result = _restClient.Execute<List<SimpleData>>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                 

                    var jsonSerializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };

                    var listForecast = JsonConvert.DeserializeObject<List<SimpleData>>(result.Content, jsonSerializerSettings);

                    return listForecast;
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

        public List<SimpleData> GetPressureForMultipleCities(List<DtoTown> towns)
        {
            var request = new RestRequest($"{_baseUrl}{_baseController}/TownsPressure", Method.Post);
            request.AddJsonBody(towns);
            try
            {
                request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
                var result = _restClient.Execute<List<SimpleData>>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    

                    var jsonSerializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };

                    var listForecast = JsonConvert.DeserializeObject<List<SimpleData>>(result.Content, jsonSerializerSettings);

                    return listForecast;
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
