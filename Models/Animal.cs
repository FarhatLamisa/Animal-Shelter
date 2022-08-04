using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Animal_Shelter.Models
{
    public class Animal
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Breed { get; set; }
        [Required]
        public String Vaccinated { get; set; }
        [Required]
        public String Neutered { get; set; }
        public String PhotoLink { get; set; }
        public String HealthConditions { get; set; }
        [Required]
        public String FoundFrom { get; set; }

    }
}
