using AutoMapper;
using SchoolMessengerAPI.Dtos;
using SchoolMessengerAPI.Dtos.Read;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Profiles
{
    public class ClaseProfile : Profile
    {
        public ClaseProfile()
        {
            CreateMap<Clase, ClaseDtoR>();
        }
    }
}
