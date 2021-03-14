﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace StarWarsMovies.Db.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    internal class MoviesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("StarWarsMovies.Db.Enitities.MovieRating", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<int>("MovieId")
                    .HasColumnType("INTEGER");

                b.Property<int>("Rating")
                    .HasColumnType("INTEGER");

                b.Property<int>("UserId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.ToTable("MoviesRatings");

                b.HasData(
                    new
                    {
                        Id = 1,
                        MovieId = 1,
                        Rating = 8,
                        UserId = 2
                    },
                    new
                    {
                        Id = 2,
                        MovieId = 5,
                        Rating = 5,
                        UserId = 14
                    },
                    new
                    {
                        Id = 3,
                        MovieId = 5,
                        Rating = 1,
                        UserId = 16
                    },
                    new
                    {
                        Id = 4,
                        MovieId = 4,
                        Rating = 7,
                        UserId = 5
                    },
                    new
                    {
                        Id = 5,
                        MovieId = 3,
                        Rating = 8,
                        UserId = 0
                    },
                    new
                    {
                        Id = 6,
                        MovieId = 5,
                        Rating = 3,
                        UserId = 6
                    },
                    new
                    {
                        Id = 7,
                        MovieId = 1,
                        Rating = 9,
                        UserId = 12
                    },
                    new
                    {
                        Id = 8,
                        MovieId = 4,
                        Rating = 7,
                        UserId = 1
                    },
                    new
                    {
                        Id = 9,
                        MovieId = 2,
                        Rating = 8,
                        UserId = 1
                    },
                    new
                    {
                        Id = 10,
                        MovieId = 2,
                        Rating = 4,
                        UserId = 2
                    },
                    new
                    {
                        Id = 11,
                        MovieId = 1,
                        Rating = 2,
                        UserId = 12
                    },
                    new
                    {
                        Id = 12,
                        MovieId = 1,
                        Rating = 8,
                        UserId = 19
                    },
                    new
                    {
                        Id = 13,
                        MovieId = 4,
                        Rating = 5,
                        UserId = 5
                    },
                    new
                    {
                        Id = 14,
                        MovieId = 2,
                        Rating = 6,
                        UserId = 13
                    },
                    new
                    {
                        Id = 15,
                        MovieId = 4,
                        Rating = 6,
                        UserId = 19
                    },
                    new
                    {
                        Id = 16,
                        MovieId = 2,
                        Rating = 7,
                        UserId = 13
                    },
                    new
                    {
                        Id = 17,
                        MovieId = 2,
                        Rating = 4,
                        UserId = 9
                    },
                    new
                    {
                        Id = 18,
                        MovieId = 3,
                        Rating = 3,
                        UserId = 10
                    },
                    new
                    {
                        Id = 19,
                        MovieId = 1,
                        Rating = 7,
                        UserId = 10
                    },
                    new
                    {
                        Id = 20,
                        MovieId = 4,
                        Rating = 1,
                        UserId = 12
                    },
                    new
                    {
                        Id = 21,
                        MovieId = 4,
                        Rating = 6,
                        UserId = 13
                    },
                    new
                    {
                        Id = 22,
                        MovieId = 3,
                        Rating = 7,
                        UserId = 14
                    },
                    new
                    {
                        Id = 23,
                        MovieId = 5,
                        Rating = 6,
                        UserId = 4
                    },
                    new
                    {
                        Id = 24,
                        MovieId = 5,
                        Rating = 1,
                        UserId = 4
                    },
                    new
                    {
                        Id = 25,
                        MovieId = 3,
                        Rating = 1,
                        UserId = 13
                    },
                    new
                    {
                        Id = 26,
                        MovieId = 1,
                        Rating = 9,
                        UserId = 1
                    },
                    new
                    {
                        Id = 27,
                        MovieId = 1,
                        Rating = 1,
                        UserId = 18
                    },
                    new
                    {
                        Id = 28,
                        MovieId = 1,
                        Rating = 4,
                        UserId = 18
                    },
                    new
                    {
                        Id = 29,
                        MovieId = 5,
                        Rating = 7,
                        UserId = 9
                    },
                    new
                    {
                        Id = 30,
                        MovieId = 2,
                        Rating = 1,
                        UserId = 2
                    },
                    new
                    {
                        Id = 31,
                        MovieId = 2,
                        Rating = 4,
                        UserId = 0
                    },
                    new
                    {
                        Id = 32,
                        MovieId = 5,
                        Rating = 6,
                        UserId = 13
                    },
                    new
                    {
                        Id = 33,
                        MovieId = 5,
                        Rating = 9,
                        UserId = 0
                    },
                    new
                    {
                        Id = 34,
                        MovieId = 1,
                        Rating = 3,
                        UserId = 8
                    },
                    new
                    {
                        Id = 35,
                        MovieId = 2,
                        Rating = 4,
                        UserId = 9
                    },
                    new
                    {
                        Id = 36,
                        MovieId = 2,
                        Rating = 3,
                        UserId = 3
                    },
                    new
                    {
                        Id = 37,
                        MovieId = 4,
                        Rating = 8,
                        UserId = 17
                    },
                    new
                    {
                        Id = 38,
                        MovieId = 5,
                        Rating = 5,
                        UserId = 8
                    },
                    new
                    {
                        Id = 39,
                        MovieId = 2,
                        Rating = 6,
                        UserId = 13
                    },
                    new
                    {
                        Id = 40,
                        MovieId = 5,
                        Rating = 8,
                        UserId = 13
                    },
                    new
                    {
                        Id = 41,
                        MovieId = 3,
                        Rating = 3,
                        UserId = 13
                    },
                    new
                    {
                        Id = 42,
                        MovieId = 4,
                        Rating = 1,
                        UserId = 8
                    },
                    new
                    {
                        Id = 43,
                        MovieId = 3,
                        Rating = 2,
                        UserId = 9
                    },
                    new
                    {
                        Id = 44,
                        MovieId = 5,
                        Rating = 1,
                        UserId = 5
                    },
                    new
                    {
                        Id = 45,
                        MovieId = 5,
                        Rating = 1,
                        UserId = 2
                    },
                    new
                    {
                        Id = 46,
                        MovieId = 5,
                        Rating = 5,
                        UserId = 15
                    },
                    new
                    {
                        Id = 47,
                        MovieId = 3,
                        Rating = 4,
                        UserId = 13
                    },
                    new
                    {
                        Id = 48,
                        MovieId = 2,
                        Rating = 3,
                        UserId = 10
                    },
                    new
                    {
                        Id = 49,
                        MovieId = 5,
                        Rating = 3,
                        UserId = 8
                    });
            });
#pragma warning restore 612, 618
        }
    }
}