﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FullCalenderDemo.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required()]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
