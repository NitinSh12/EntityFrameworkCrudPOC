using Demo.DataAccess;
using Demo.DataModels;
using Demo.Domain;
using Demo.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Repository.Class
{
    public class CityRepository: ICityRepository
    {
        private readonly DemoDbContext _demoDbContext;

        public CityRepository(DemoDbContext demoDbContext)
        {
            _demoDbContext = demoDbContext;
        }

        public async Task<CityDataModel> GetCity(Guid id)
        {
            return await _demoDbContext.CityMaster.FirstOrDefaultAsync(a => a.CityId == id);
        }

        public async Task<IEnumerable<CityDataModel>> GetCities()
        {
            return await _demoDbContext.CityMaster.ToListAsync();
        }

        public async Task<CityDataModel> UpdateCity(Guid id, string name)
        {
            var cityFound = await _demoDbContext.CityMaster.FindAsync(id);
            cityFound.CityName = name;
            return cityFound;
        }

        public async Task AddCity (CityDataModel city)
        {
            await _demoDbContext.CityMaster.AddAsync(city);
            await _demoDbContext.SaveChangesAsync();
        }

        public async Task RemoveCity (Guid id)
        {
            var city = _demoDbContext.CityMaster.Find(id);

            if(city != null)
            {
                _demoDbContext.CityMaster.Remove(city);
                await _demoDbContext.SaveChangesAsync();
            }
        }
    }
}
