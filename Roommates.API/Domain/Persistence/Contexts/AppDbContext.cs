using Microsoft.EntityFrameworkCore;
using Roommates.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roommates.API.Domain.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Lessor> Lessors { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<Advertisement> advertisements { get; set; }
        public DbSet<Reservation> reservations { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
