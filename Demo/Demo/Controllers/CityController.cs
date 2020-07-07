using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Domain;
using Demo.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [ApiController]
    [Route("api/city")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService; 
        }

        [HttpGet("all")]
        public async Task<IEnumerable<CityModel>> GetCities()
        {
            return await _cityService.GetCities();
        }

        [HttpPost]
        public async Task AddCity(CityModel city)
        {
            city.CityId = Guid.NewGuid();
            await _cityService.AddCity(city);
        }

    }
}