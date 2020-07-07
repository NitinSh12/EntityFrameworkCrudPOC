using Demo.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Repository.Interface
{
    public interface ICityRepository
    {
        public Task<CityDataModel> GetCity(Guid id);
        public Task<IEnumerable<CityDataModel>> GetCities();
        public Task<CityDataModel> UpdateCity(Guid id, string name);
        public Task AddCity(CityDataModel city);
        public Task RemoveCity(Guid id);
    }
}
