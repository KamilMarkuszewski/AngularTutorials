using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Slave
    {
        public int Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        [Required]
        public string Surname { get; set; }

        // Its obvoius, cat is owner of human, not opposite
        public ICollection<Cat> Cats { get; set; }
    }
}
