using System;

namespace TheMovie.Business.Interfaces.Entities
{
    public interface IMovie
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime ReleaseDate { get; set; }
    }
}
