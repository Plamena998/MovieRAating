
using Fluent.Infrastructure.FluentModel;
using MovieRating2000.Models;
using System.Data.Entity;

namespace Data_Context
{
    public class MovieDbContext : ApplicationDbContext
    {
        DbSet<Cast> Casts
    }
}
