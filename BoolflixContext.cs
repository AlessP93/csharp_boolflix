﻿using csharp_boolflix.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix
{
    public class BoolflixContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MediaInfo> MediaInfos { get; set; }
        public DbSet<Pegi> Pegis { get; set; }
        public DbSet<TVSerie> TVSeries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db_boolflix;Integrated Security=True");
        }
    }
}
