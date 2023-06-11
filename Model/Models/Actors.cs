using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSmestralny.Models
{
    public class Actors
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("first_name")]
        public string? FirstName { get; set; }

        [Required, MaxLength(50)]
        public string? LastName { get; set; }
    }
}
