using AutoMapper;
using DAL.Dto;
using DAL.Entities;

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
