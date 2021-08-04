using CuerpoSanoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuerpoSanoWebApi.Repository.IRepository
{
    public interface ICSE_MusculosRepository
    {
        ICollection<CSE_Musculos> GetCSE_Musculos();
    }

 
}
