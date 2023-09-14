using AutoMapper;
using DTOs;
using Entidades;
using Helpers;

namespace Profiles
{
    public class PersonaProfile : Profile
    {

        public PersonaProfile() 
       
        { 

            CreateMap<Persona,PersonaDTO>().ReverseMap();

            CreateMap<Persona, PersonaDTO>().ForMember(dest => dest.Edad ,opt => opt.MapFrom(src => src.FechaNacimiento.GetCurrentAge()));
        
            CreateMap<Persona, PersonaCrearDTO>().ReverseMap(); 

        }

    }
}