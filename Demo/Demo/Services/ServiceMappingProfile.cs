using AutoMapper;
using Demo.DataModels;
using Demo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            CreateMap<CityDataModel, CityModel>()
                .ReverseMap();

        }
    }
}
