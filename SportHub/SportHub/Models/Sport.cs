using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportHub.Models
{
    public class Sport
    {
        public int Id { get; set; }

      
        public  ApplicationUser Player { get; set; }

        [Required]
        public string PlayerId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Complex { get; set; }

        public Type Type { get; set; }

        [Required]
        public byte TypeId { get; set; }
    }
    
}