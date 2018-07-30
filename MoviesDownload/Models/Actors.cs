﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MoviesDownload.Models
{
    public class Actors
    {
        public Actors()
        {
            this.Movies = new HashSet<Movies>();
        }
        

        [Key]
        public int ActorId { get; set; }

        [Required(ErrorMessage ="Please enter Actor Name")]
        [StringLength(50, MinimumLength = 03)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sex is required")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date Format")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        [StringLength(1000, MinimumLength = 10)]
        public string Bio { get; set; }

        public virtual ICollection<Movies> Movies { get; set; } = null;
    }
}