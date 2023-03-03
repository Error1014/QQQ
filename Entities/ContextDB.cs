using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ContextDB:DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employ> Emplois { get; set; }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Otdel> Otdels { get; set; }
    }
}
