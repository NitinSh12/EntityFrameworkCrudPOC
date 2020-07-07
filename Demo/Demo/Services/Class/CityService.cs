using AutoMapper;
using Demo.Domain;
using Demo.Repository.Interface;
using Demo.Services.Converters;
using Demo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Class
{
    public class CityService: ICityService
    {
        private readonly ICityRepository _demoRepository;
        private readonly IMapper _mapper;

        public CityService(ICityRepository demoRepository, IMapper mapper)
        {
            _demoRepository = demoRepository;
            _mapper = mapper;
        }

        public async Task<CityModel> GetCity(Guid id)
        {
            var cityResult = await _demoRepository.GetCity(id);
            return cityResult.ToCoreModel(_mapper);
        }

        public async Task<IEnumerable<CityModel>> GetCities()
        {
            var cityResult = await _demoRepository.GetCities();
            return cityResult.ToCoreModel(_mapper);
        }

        public async Task<CityModel> UpdateCity(Guid id, string name)
        {
            var cityResult = await _demoRepository.UpdateCity(id, name);
            return cityResult.ToCoreModel(_mapper);
        }

        public async Task AddCity(CityModel city)
        {
            var cityDataModel = city.ToCoreDataModel(_mapper);
            await _demoRepository.AddCity(cityDataModel);
        }

        public async Task RemoveCity(Guid id)
        {
            await _demoRepository.RemoveCity(id);
        }

    }
}
