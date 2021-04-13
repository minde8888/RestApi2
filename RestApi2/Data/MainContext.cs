using Microsoft.EntityFrameworkCore;
using RestApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi2.Data
{
    public class MainContext : DbContext
    {
        public DbSet<Crockerys> Crockerys { get; set; }
        public DbSet<Fruits> Fruits { get; set; }
        public DbSet<Vegetables> Users { get; set; }


        public MainContext(DbContextOptions<MainContext> options) : base(options)
        { }       
    }
}
