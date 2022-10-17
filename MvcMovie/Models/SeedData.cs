using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using MvcMovie.Migrations;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    }
                );

                context.Suggestion.AddRange(
                   new Suggestion
                   {
                       Title = "Fixing the oak doors",
                       Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lorem ipsum, malesuada et sagittis vel, elementum ac ligula. ",
                       Team="Team 1",
                       StartDate = DateTime.Parse("1959-4-15"),
                       Owner = "Hilde Gunn",
                       Status = "Do",
                   },
                   new Suggestion
                   {
                       Title = "Instaling the sensor activated doors",
                       Description = "Suspendisse mollis sagittis ipsum sit amet dignissim.",
                       Team = "Team 2",
                       StartDate = DateTime.Parse("1999-4-15"),
                       Owner = "Tom Anderson",
                       Status = "Plan",
                   }
                );

                context.SaveChanges();
            }
        }
    }
}