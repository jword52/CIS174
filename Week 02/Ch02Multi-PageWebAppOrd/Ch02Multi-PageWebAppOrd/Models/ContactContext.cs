using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ch02Multi_PageWebAppOrd.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Peter Parker",
                    Number = 621-383-9000,
                    Address = "1234 Main Street, Queens NY 12345",
                    Note = "Friendly Neighborhood Spider-Man"
                }
                );
        }
    }
}
