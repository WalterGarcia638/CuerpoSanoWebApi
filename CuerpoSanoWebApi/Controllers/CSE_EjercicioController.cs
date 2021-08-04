using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CuerpoSanoWebApi.Models.Dtos;
using CuerpoSanoWebApi.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CuerpoSanoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSE_EjercicioController : ControllerBase
    {
        private readonly ICSE_EjercicioRepository _cERepo;
        private readonly IMapper _mapper;

        public CSE_EjercicioController(ICSE_EjercicioRepository cERepo,
                                       IMapper mapper) 
        {
            _cERepo = cERepo;
            _mapper = mapper;            
        }

        [HttpGet]
        public IActionResult GetCSE_Ejercicios() 
        {
            var ListaCSE_Ejercicios    = _cERepo.GetCSE_Ejercicio();
            var ListaCSE_EjerciciosDto = new List<CSE_EjercicioDto>();

            foreach (var lista in ListaCSE_Ejercicios) 
            {
                ListaCSE_EjerciciosDto.Add(_mapper.Map<CSE_EjercicioDto>(lista));
                            
            }

            return Ok(ListaCSE_EjerciciosDto);


        }
    }
}
