﻿using System;
using TheMovie.Business.Interfaces.Entities;

namespace TheMovie.Business.Entities
{
    public class Movie : IMovie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
