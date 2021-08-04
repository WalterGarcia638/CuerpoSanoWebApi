using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuerpoSanoWebApi.Models
{
    public class CSE_Musculos
    {

        [Key]
        public int Id { get; set; }
        public string NombreMusculo { get; set; }
        public string DescripcionMusculo { get; set; }
        public string CuidadoDelMusculo { get; set; }
        public string UrlImagen { get; set; }
    }
}
