using AutoMapper;
using CuerpoSanoWebApi.Models;
using CuerpoSanoWebApi.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuerpoSanoWebApi.Mapper
{
    public class CuerpoSanoMapper : Profile
    {
        public CuerpoSanoMapper() 
        {
            CreateMap<CSE_Ejercicio, CSE_EjercicioDto>().ReverseMap();
            CreateMap<CSE_Musculos, CSE_MusculosDto>().ReverseMap();

        }
    }
}
