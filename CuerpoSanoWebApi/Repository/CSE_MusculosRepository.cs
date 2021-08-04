using CuerpoSanoWebApi.Data;
using CuerpoSanoWebApi.Models;
using CuerpoSanoWebApi.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuerpoSanoWebApi.Repository
{
    public class CSE_MusculosRepository : ICSE_MusculosRepository
    {
        private readonly ApplicationDbContext _db;

        public CSE_MusculosRepository(ApplicationDbContext db) 
        {
            _db = db;
        }

        public ICollection<CSE_Musculos> GetCSE_Musculos()
        {
            return _db.CSE_Musculos.OrderBy(I => I.Id).ToList();
        }
    }
}
