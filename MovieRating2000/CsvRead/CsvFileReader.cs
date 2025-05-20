using CsvHelper;
using MovieRating2000.GlobalParams;
using MovieRating2000.Models;
using System.Collections.Immutable;
using System.Globalization;

namespace MovieRating2000
{
    public class CsvFileReader
    {
        public List<Model> GetData()
        {
            using (var reader = new StreamReader(GlobalParams.GlobalParams.fileDir))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ModelClassMap>();
                var movies = csv.GetRecords<Model>()
                    .Where(m =>!string.IsNullOrWhiteSpace(m.MovieName))
                    .ToList();
                return movies;
            }
           
        }
    }
}
