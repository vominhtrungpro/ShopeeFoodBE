﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeFoodBE.DAL.EF.Entities
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required(ErrorMessage = "City name is needed")]
        public string CityName { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public List<Restaurant> Restaurant { get; set; }
    }
}
