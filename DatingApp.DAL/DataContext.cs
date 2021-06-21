using DatingApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DAL
{
    public class DataContext : DbContext
    {
        private readonly string _connString;
        public DataContext()
        {
            _connString = @"server=LAPTOP-03RLPA2O\SQLEXPRESS;Database=DatingApp; Integrated Security=True;";
        }

        public DataContext(string connString)
        {
            _connString = connString;
        }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connString);
        }

    }
}
