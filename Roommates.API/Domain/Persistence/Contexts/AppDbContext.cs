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

        protected override void OnModelCreating (ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Student Entity
            builder.Entity<Student>().ToTable("Students");
            builder.Entity<Student>().HasKey(s => s.studentId);
            builder.Entity<Student>().Property(s => s.studentId).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Student>().Property(s => s.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Student>().Property(s => s.LastName).IsRequired().HasMaxLength(50);
            builder.Entity<Student>().Property(s => s.Dni).IsRequired().HasMaxLength(8);
            builder.Entity<Student>().Property(s => s.Telephone).IsRequired().HasMaxLength(25);
            builder.Entity<Student>().Property(s => s.sexo).IsRequired().HasMaxLength(10);
            builder.Entity<Student>().Property(s => s.dateBirthday).IsRequired().HasMaxLength(10);
            builder.Entity<Student>().Property(s => s.hobbies).IsRequired().HasMaxLength(30);
            builder.Entity<Student>().Property(s => s.premium).IsRequired().ValueGeneratedOnAdd();

            //Save Data
            builder.Entity<Student>().HasData
                (
                    new Student { studentId = 100, Name = "Andre Diaz", LastName = "Diaz Quiroz", Dni = 71328381, Telephone = "952252313", sexo = "Masculino", dateBirthday = "06-07-1991", hobbies = "Videos Juegos", premium = true}
                );
        }
    }
}
