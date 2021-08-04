using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuerpoSanoWebApi.Models.Dtos
{
    public class CSE_MusculosDto
    {
        public int Id { get; set; }
        public string NombreMusculo { get; set; }
        public string DescripcionMusculo { get; set; }
        public string CuidadoDelMusculo { get; set; }
        public string UrlImagen { get; set; }
    }
}
