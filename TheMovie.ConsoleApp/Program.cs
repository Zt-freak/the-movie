using System;
using TheMovie.Business.Context;
using TheMovie.Business.Services;

namespace TheMovie.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Movie!");
            var context = new MoviesDataContext();
            var service = new MoviesService(context);
            int id = Int32.Parse(Console.ReadLine());
            var movie = service.GetById(id);
            Console.WriteLine($"{movie.Id}, {movie.Name}, {movie.ReleaseDate}");
        }
    }
}
