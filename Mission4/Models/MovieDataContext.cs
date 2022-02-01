using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission4.Models
{
    public class MovieDataContext : DbContext
    {
        //Constructor
        public MovieDataContext (DbContextOptions<MovieDataContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Seeded data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID=1, CategoryName="Action/Adventure"},
                new Category { CategoryID=2, CategoryName="Comedy"},
                new Category { CategoryID=3, CategoryName="Drama"},
                new Category { CategoryID=4, CategoryName="Family"},
                new Category { CategoryID=5, CategoryName="Horror/Suspense"},
                new Category { CategoryID=6, CategoryName="Miscellaneous"},
                new Category { CategoryID=7, CategoryName="Television"},
                new Category { CategoryID=8, CategoryName="VHS"}
            );

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieId = 1,
                    CategoryID = 1,
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    CategoryID = 1,
                    Title = "Spider-Man: Into the Spider-Verse",
                    Year = 2018,
                    Director = "Bob Persichetti",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    CategoryID = 1,
                    Title = "Transformers",
                    Year = 2007,
                    Director = "Michael Bay",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }

            );
        }
    }
}
