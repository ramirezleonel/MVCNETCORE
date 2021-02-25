using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using crudEntityFramework.Models;


namespace crudEntityFramework.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base (options){


        }

    public DbSet<Usuario> Usuario {set;get;}
    }


}