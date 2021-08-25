using System.Collections.Generic;
using TheMovie.Business.Context;
using TheMovie.Business.Interfaces.Context;
using TheMovie.Business.Interfaces.Entities;
using TheMovie.Business.Interfaces.Services;

namespace TheMovie.Business.Services
{
    public class MoviesService : IMovieService
    {
        private readonly IMoviesDataContext _datacontext;

        public MoviesService(MoviesDataContext context)
        {
            _datacontext = context;
        }
        public IEnumerable<IMovie> GetAll()
        {
            return _datacontext.Movies;
        }

        public IMovie GetById(int id)
        {
            return _datacontext.Movies.Find(id);
        }
    }
}
