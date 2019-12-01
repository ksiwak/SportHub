﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportHub.Models
{
    public class Type
    {
       
            public byte Id { get; set; }

            [Required]
            [StringLength(255)]
            public string Name { get; set; }
       
    }
}