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
            CreateMap<Clase, ClaseDtoR>()
                .ForMember(dest => dest.Materia, o => o.MapFrom(src => src.Subject.Name))
                .ForMember(dest => dest.Salon, o => o.MapFrom(src => src.Room.Name));
        }
    }
}
