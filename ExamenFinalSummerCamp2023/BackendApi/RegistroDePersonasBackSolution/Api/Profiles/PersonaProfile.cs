using AutoMapper;
using Domain.Model;
using DTO;

namespace Api.Profiles
{
    public class PersonaProfile : Profile
    {
        public PersonaProfile() {
            CreateMap<Persona, PersonaGetDTO>().ForMember(dto => dto.anios, ent =>
                ent.MapFrom(val => $"{ConvertirDateEnAnios(val.FechaNacimiento)}"));

            CreateMap<PersonaPostDTO, Persona>().ForMember(p => p.Id, ent =>
                ent.MapFrom(val => new Guid()));
        }

        private static int ConvertirDateEnAnios(DateTime date)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - date.Year;

            if (fechaActual.Month < date.Month || (fechaActual.Month == date.Month && fechaActual.Day < date.Day))
            {
                edad--;
            }

            return edad;
        }
    }
}
