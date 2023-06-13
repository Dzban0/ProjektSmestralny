using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSmestralny.Models
{
    public class Films
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public int ReleaseYear { get; set; }

        public ICollection<Actors>? Actors { get; set; }
        public ICollection<Category>? Category { get; set; }
    }
}
