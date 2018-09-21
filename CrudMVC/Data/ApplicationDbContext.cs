using CrudMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
           
        }
    }
}
