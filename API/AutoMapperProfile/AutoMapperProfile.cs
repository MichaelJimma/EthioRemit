using AutoMapper;
using DAL.Dto;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ClientTypes, ClientTypeDto>().ReverseMap();
        }
    }
}
