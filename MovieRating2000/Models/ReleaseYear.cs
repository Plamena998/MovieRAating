using MovieRating2000.Base_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating2000.Models
{
    public class ReleaseYear:BaseModel
    {
        public int Year { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
