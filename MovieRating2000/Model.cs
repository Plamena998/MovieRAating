﻿using MovieRating2000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating2000
{
    public class Model
    {
        public string MovieName {  get; set; }
        public int  ReleaseYear { get; set; }
        public int Duration { get; set; }
        public double IMDBRating { get; set; }
        public double Metascore { get; set; }
        public double Votes { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }    
        public string Cast { get; set; }
        public double Gross { get; set; }
    }
}
