using CuerpoSanoWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuerpoSanoWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CSE_Ejercicio> CSE_Ejercicio { get; set; }
        public DbSet<CSE_Musculos> CSE_Musculos { get; set; }
    }
}
