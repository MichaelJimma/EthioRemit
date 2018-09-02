using AutoMapper;
using DAL.Dto;
using DAL.Entities;

namespace BLL.Services
{
    public class ClientTypeProfile : Profile
    {
        public ClientTypeProfile()
        {
            CreateMap<ClientTypes, ClientTypeDto>().ReverseMap();
        }
    }
}
