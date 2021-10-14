using Microsoft.EntityFrameworkCore;
using Naipealejandra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naipealejandra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Naipe> Naipe { get; set; }
    }
}
