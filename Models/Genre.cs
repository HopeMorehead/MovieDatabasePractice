﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieDatabasePractice.Models
{
    public class Genre
    {

        [Key]
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<Movie>Movies { get; set; }










    }
}