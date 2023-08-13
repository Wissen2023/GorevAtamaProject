
using GorevAtamaProject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtamaProject.Data.Concrete
{
    public class GorevAtamaProjectContext : DbContext
    {
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Islem> Islems { get; set; }
        public DbSet<Rol> Rols { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-OVE5E20\\SQLEXPRESS; Database = W2023DB; User = sa4; Password = 123456");
        }
    }
}
