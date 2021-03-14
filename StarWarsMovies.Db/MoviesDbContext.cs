using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StarWarsMovies.Db.Enitities;

namespace StarWarsMovies.Db
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MovieRating> MoviesRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieRating>().ToTable("MoviesRatings");

            #region seed data

            var moviesRatingsSeed = new List<MovieRating>();

            var rnd = new Random();
            for (var i = 1; i < 50; i++)
                moviesRatingsSeed.Add(new MovieRating
                    {Id = i, Rating = rnd.Next(1, 10), MovieId = rnd.Next(1, 6), UserId = rnd.Next(20)});

            modelBuilder.Entity<MovieRating>().HasData(moviesRatingsSeed);

            modelBuilder.Entity<MovieRating>(builder =>
            {
                builder.Property(m => m.Rating).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
                builder.Property(m => m.MovieId).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
                builder.Property(m => m.UserId).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(
                "Data Source=../StarWarsMovies.db").EnableSensitiveDataLogging();
        }
    }
}