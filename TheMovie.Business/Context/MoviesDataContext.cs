using Microsoft.EntityFrameworkCore;
using System;
using TheMovie.Business.Entities;
using TheMovie.Business.Interfaces.Context;

namespace TheMovie.Business.Context
{
    public class MoviesDataContext : DbContext, IMoviesDataContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=TheMovieEF");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new { Id = 1, Name = "Jaws", ReleaseDate = new DateTime(1975, 1, 1) },
                new { Id = 2, Name = "Luca", ReleaseDate = new DateTime(2021, 1, 1) },
                new { Id = 3, Name = "Kill Bill", ReleaseDate = new DateTime(2003, 1, 1) },
                new { Id = 4, Name = "Bee Movie", ReleaseDate = new DateTime(2007, 1, 1) },
                new { Id = 5, Name = "Test", ReleaseDate = new DateTime(2003, 1, 1) }
            );
        }
    }
}
