using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherWebApp.DomainServices.Base;
using WeatherWebApp.Model.Api;
using WeatherWebApp.Model.Api.DTO;

namespace WeatherWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PublicDataController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ITownService _townService;
        private readonly ITranslatorService _translatorService;

        public PublicDataController(IConfiguration configuration, ITownService townService, ITranslatorService translatorService)
        {
            _townService = townService;
            _configuration = configuration;
            _translatorService = translatorService;
        }

        [HttpGet]
        public bool ping()
        {
            var resultList = _townService.GetSynopticData();
            if(resultList == null)
            {
                return false;
            }

            return true;
        }

        [HttpPost]
        public ActionResult<List<SimpleData>> TownsWeather([FromBody] List<DtoTown> towns)
        {

            if (!SecurityCheck(Request.Headers))
            {
                return Unauthorized();
            }
            var resultList = _townService.GetWeatherForTowns(towns);
            if(resultList == null)
            {
                return NotFound();
            }


            return resultList;
        }

        [HttpPost]
        public ActionResult<List<SimpleData>> TownsHumidity([FromBody] List<DtoTown> towns)
        {

            if (!SecurityCheck(Request.Headers))
            {
                return Unauthorized();
            }
            var resultList = _townService.GetHumidityForTowns(towns);
            if (resultList == null)
            {
                return NotFound();
            }


            return resultList;
        }

        [HttpPost]
        public ActionResult<List<SimpleData>> TownsPressure([FromBody] List<DtoTown> towns)
        {

            if (!SecurityCheck(Request.Headers))
            {
                return Unauthorized();
            }
            var resultList = _townService.GetPressureForTowns(towns);
            if (resultList == null)
            {
                return NotFound();
            }


            return resultList;
        }

        [HttpGet]
        public ActionResult<List<SynopticData>> AllTowns()
        {
            if (!SecurityCheck(Request.Headers))
            {
                return Unauthorized();
            }
            var resultList = _townService.GetSynopticData();

            if(resultList == null)
            {
                return NotFound();
            }

            return resultList;
        }

        [HttpGet]
        public ActionResult<List<string>> TownList()
        {
            if (!SecurityCheck(Request.Headers))
            {
                return Unauthorized();
            }

            var resultingList = _townService.GetTownsList();

            if (resultingList == null)
                return NotFound();

            return resultingList;
        }

        [HttpGet]
        public ActionResult<TownInfo> Town()
        {
            
            if (!SecurityCheck(Request.Headers))
            {
                return Unauthorized();
            }

            var cityName = Uri.UnescapeDataString(Request.Headers["CityName"]);
            if (string.IsNullOrEmpty(cityName))
            {
                return NotFound();
            }

            var normalizedName = _translatorService.ToSimplePolish(cityName);

            var result = _townService.GetTown(normalizedName);

            if (result == null) return NotFound();
            return result;
        }


        private bool SecurityCheck(IHeaderDictionary requestHeaders)
        {
            if (requestHeaders.TryGetValue("client-token", out var token))
            {
                var tokenValue = token.FirstOrDefault();
                if (string.IsNullOrWhiteSpace(tokenValue))
                    return false;

                var localToken = _configuration.GetValue<string>("ClientToken");
                if (string.IsNullOrWhiteSpace(localToken))
                    return false;

                if (tokenValue == localToken)
                    return true;
            }

            return false;
        }
    }
}
