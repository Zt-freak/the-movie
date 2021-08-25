using System.Collections.Generic;
using TheMovie.Business.Interfaces.Entities;

namespace TheMovie.Business.Interfaces.Services
{
    public interface IMovieService
    {
        public IEnumerable<IMovie> GetAll();
        public IMovie GetById(int id);
    }
}
