using CuerpoSanoWebApi.Data;
using CuerpoSanoWebApi.Models;
using CuerpoSanoWebApi.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuerpoSanoWebApi.Repository
{
    public class CSE_EjercicioRepository : ICSE_EjercicioRepository
    {
        public readonly ApplicationDbContext _db;

        public CSE_EjercicioRepository(ApplicationDbContext db) 
        {
            _db = db;
        }
        public bool ActualizarCSE_Ejercicio(CSE_Ejercicio CSE_Ejercicio)
        {
            _db.CSE_Ejercicio.Update(CSE_Ejercicio);
            return Guardar();
        }

        public bool BorrarCSE_Ejercicio(CSE_Ejercicio CSE_Ejercicio)
        {
            _db.CSE_Ejercicio.Remove(CSE_Ejercicio);
            return Guardar();
        }

        public bool CrearCSE_Ejercicio(CSE_Ejercicio CSE_Ejercicio)
        {
            _db.CSE_Ejercicio.Add(CSE_Ejercicio);
            return Guardar();
        }

        public bool ExisteCSE_Ejercicio(string nombreEjercicio)
        {
            bool valor = _db.CSE_Ejercicio.Any(Ne => Ne.NombreEjercicio.ToLower().Trim() == nombreEjercicio.ToLower().Trim());
            return valor;
        }

        public bool ExisteCSE_Ejercicio(int id_ejercicio)
        {
            bool valor = _db.CSE_Ejercicio.Any(Id => Id.Id == id_ejercicio);
            return valor;
        }

     

        public CSE_Ejercicio GetCSE_EjercicioById(int ejercicioId)
        {
            return _db.CSE_Ejercicio.FirstOrDefault(E => E.Id == ejercicioId);
        }

      
        public CSE_Ejercicio GetCSE_EjercicioByName(string nombreEjercicio)
        {
            return _db.CSE_Ejercicio.FirstOrDefault(NE => NE.NombreEjercicio == nombreEjercicio);
        }

     
        public ICollection<CSE_Ejercicio> GetCSE_Ejercicio()
        {
            return _db.CSE_Ejercicio.OrderBy(Id => Id.Id).ToList();
        }


        public bool Guardar()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
