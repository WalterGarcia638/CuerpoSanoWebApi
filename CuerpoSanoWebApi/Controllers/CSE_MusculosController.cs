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
    public class CSE_MusculosController : ControllerBase
    {
        private readonly ICSE_MusculosRepository _cMRepo;
        private readonly IMapper _mapper;
        public CSE_MusculosController(ICSE_MusculosRepository cMRepo,
                                      IMapper mapper) 
        {
            _cMRepo = cMRepo;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult GetCSE_Musculos() 
        {
            var listaCSE_Musculos = _cMRepo.GetCSE_Musculos();
            var listaCSE_MusculosDto = new List<CSE_MusculosDto>();

            foreach (var lista in listaCSE_Musculos) 
            {
                listaCSE_MusculosDto.Add(_mapper.Map<CSE_MusculosDto>(lista));
            }
            return Ok(listaCSE_MusculosDto);
        }

    }
}
