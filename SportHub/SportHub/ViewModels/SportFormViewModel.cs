using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SportHub.Models;

namespace SportHub.ViewModels
{
    public class SportFormViewModel
    {
        [Required]
        public string  Complex { get; set; }

        [Required]
        [CustomDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Type { get; set; }
       // public IEnumerable<Type> Types1 { get; set; }
        public List<Models.Type> Types { get; internal set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse($"{Date} {Time}");
        }
    }
}