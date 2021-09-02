﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChill.Server.Domain
{
   public class MovieList
   {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set;}
        public User User { get; set;}
        public Guid UserId { get; set; }
        public Movie Movie { get; set; }
        public Guid MovieId { get; set; }

   }
}