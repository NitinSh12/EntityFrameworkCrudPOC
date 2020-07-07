using AutoMapper;
using Demo.DataModels;
using Demo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Converters
{
    public static class CityCoreModelConverter
    {
        public static IEnumerable<CityModel> ToCoreModel(this IEnumerable<CityDataModel> cities, IMapper mapper)
        {
            return mapper.Map<IEnumerable<CityDataModel>, IEnumerable<CityModel>>(cities);
        }

        public static CityModel ToCoreModel(this CityDataModel city, IMapper mapper)
        {
            return mapper.Map<CityDataModel, CityModel>(city);
        }

        public static CityDataModel ToCoreDataModel(this CityModel city, IMapper mapper)
        {
            return mapper.Map<CityModel, CityDataModel>(city);
        }
    }
}
