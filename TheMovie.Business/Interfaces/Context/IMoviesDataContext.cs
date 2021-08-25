using Microsoft.EntityFrameworkCore;
using TheMovie.Business.Entities;

namespace TheMovie.Business.Interfaces.Context
{
    public interface IMoviesDataContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
