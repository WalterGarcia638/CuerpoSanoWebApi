using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuerpoSanoWebApi.Models
{
    public class CSE_Ejercicio
    {
        [Key]
        public int Id { get; set; }
        public string NombreEjercicio { get; set; }
        public string Descripcion { get; set; }
        public string Recomendaciones { get; set; }
        public string MusculoTrabajado { get; set; }
        public string MusculosSecundario { get; set; }
        public string UrlFoto { get; set; }
        public string UrlVideo { get; set; }
        public string RepeticionesRecomendadas { get; set; }
        public int TiempoRecomendado { get; set; }
    }
}
