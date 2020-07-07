using Demo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Interface
{
    public interface ICityService
    {
        public Task<CityModel> GetCity(Guid id);
        public Task<IEnumerable<CityModel>> GetCities();
        public Task<CityModel> UpdateCity(Guid id, string name);
        public Task AddCity(CityModel city);
        public Task RemoveCity(Guid id);
    }
}
