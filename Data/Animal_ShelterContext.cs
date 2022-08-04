using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Animal_Shelter.Models;

namespace Animal_Shelter.Data
{
    public class Animal_ShelterContext : DbContext
    {
        public Animal_ShelterContext (DbContextOptions<Animal_ShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal_Shelter.Models.Animal> Animal { get; set; }
    }
}
