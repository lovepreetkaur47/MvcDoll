using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcDoll.Data;
using System;
using System.Linq;

namespace MvcDoll.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MvcDollContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcDollContext>>());
            {
                // Look for any movies.
                if (context.Doll.Any())
                {
                    return;   // DB has been seeded
                }

                context.Doll.AddRange(
                    new Doll
                    {
                        Type = "fashion",
                        LaunchDate = DateTime.Parse("1980-2-12"),
                        Color = "Pink",
                        Price = 10.99M
                    },

                    new Doll
                    {
                        Type = "Patch Kid",
                        LaunchDate = DateTime.Parse("1984-3-13"),
                        Color = "Skin",
                        Price = 9.99M
                    },

                    new Doll
                    {
                        Type = "base models",
                        LaunchDate = DateTime.Parse("2000-2-23"),
                        Color = "white",
                        Price = 9.99M
                    },

                    new Doll
                    {
                        Type = "Action",
                        LaunchDate = DateTime.Parse("1959-4-15"),
                        Color = "blue",
                        Price = 4.99M
                    },
                    new Doll
                    {
                        Type = "Black Doll",
                        LaunchDate = DateTime.Parse("2003-4-17"),
                        Color = "Black",
                        Price = 5.99M
                    },
                    new Doll
                    {
                        Type = "Taddy",
                        LaunchDate = DateTime.Parse("1879-4-15"),
                        Color = "Red",
                        Price = 10.99M
                    },
                    new Doll
                    {
                        Type = "Parian Doll",
                        LaunchDate = DateTime.Parse("1930-8-10"),
                        Color = " skin-like",
                        Price = 73.99M
                    },
                    new Doll
                    {
                        Type = "all-jointed doll",
                        LaunchDate = DateTime.Parse("1959-4-15"),
                        Color = "White",
                        Price = 3.99M
                    },
                    new Doll
                    {
                        Type = "Magic",
                        LaunchDate = DateTime.Parse("1959-4-15"),
                        Color = "Green",
                        Price = 3.99M
                    },
                    new Doll
                    {
                        Type = "Paper doll",
                        LaunchDate = DateTime.Parse("1959-4-15"),
                        Color = "Muti-color",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }

}
