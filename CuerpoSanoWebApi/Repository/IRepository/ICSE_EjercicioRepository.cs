using CuerpoSanoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuerpoSanoWebApi.Repository.IRepository
{
    public interface ICSE_EjercicioRepository
    {
        ICollection<CSE_Ejercicio> GetCSE_Ejercicio();
        CSE_Ejercicio GetCSE_EjercicioById(int ejercicioId);
        CSE_Ejercicio GetCSE_EjercicioByName(string nombreEjercicio);
        bool ExisteCSE_Ejercicio(string nombreEjercicio);
        bool ExisteCSE_Ejercicio(int id_ejercicio);
        bool CrearCSE_Ejercicio(CSE_Ejercicio CSE_Ejercicio);
        bool ActualizarCSE_Ejercicio(CSE_Ejercicio CSE_Ejercicio);
        bool BorrarCSE_Ejercicio(CSE_Ejercicio CSE_Ejercicio);
        bool Guardar();

    }
}
