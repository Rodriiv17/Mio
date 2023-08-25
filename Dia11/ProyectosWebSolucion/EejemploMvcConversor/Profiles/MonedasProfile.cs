using ApiJsonBiblioteca;
using AutoMapper;
using EejemploMvcConversor.Models;

namespace EejemploMvcConversor.Profiles
{
    public class MonedasProfile : Profile
    {
        public MonedasProfile() 
        {
            CreateMap<MonedaJson, Moneda>();
        }

    }
}
