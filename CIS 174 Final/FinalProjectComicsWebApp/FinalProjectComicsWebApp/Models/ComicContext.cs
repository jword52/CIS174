using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectComicsWebApp.Models
{
    //comic context class, holds database connections that created the migration based on the coded tables below
    public class ComicContext :DbContext
    {
        public ComicContext(DbContextOptions<ComicContext> options) : base(options)
        {

        }

        public DbSet<Comic> Comics { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comic>().HasData(
                new Comic
                {
                    ComicId = 1,
                    Title = "Amazing Spider-Man 300",
                    Rating = 4,
                    TotalReviews = 2
                },
                new Comic
                {
                    ComicId = 2,
                    Title = "Detective Comics 27",
                    Rating = 4,
                    TotalReviews = 2
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    UserName = "JOrd",
                    Password = "JohnOrd!",
                    AuthLevel = 2
                },
                new User
                {
                    UserId = 2,
                    UserName = "RegularUser",
                    Password = "password",
                    AuthLevel = 1
                }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    ReviewId = 1,
                    UserId = 1,
                    ComicId = 1,
                    Rating = 4,
                    ReviewContent = "It's pretty good"
                },
                new Review
                {
                    ReviewId = 2,
                    UserId = 2,
                    ComicId = 1,
                    Rating = 4,
                    ReviewContent = "Good Comic!"
                },
                new Review
                {
                    ReviewId = 3,
                    UserId = 1,
                    ComicId = 2,
                    Rating = 4,
                    ReviewContent = "It's alright"
                },
                new Review
                {
                    ReviewId = 4,
                    UserId = 2,
                    ComicId = 2,
                    Rating = 4,
                    ReviewContent = "I really enjoyed this comic"
                }
            );
        }
    }
}
