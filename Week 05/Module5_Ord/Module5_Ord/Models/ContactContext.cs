using Module5_Ord.Models;
using Microsoft.EntityFrameworkCore;

namespace Module5_Ord.Models
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
                    ContactID = 1,
                    ContactName = "Grog Strongjaw",
                    ContactPhone = "555-253-4764",
                    ContactAddress = "Whitestone Castle, Whitestone",
                    ContactNote = "also ale"
                },
                new Contact
                {
                    ContactID = 2,
                    ContactName = "Obi-Wan Kenobi",
                    ContactPhone = "555-367-2311",
                    ContactAddress = "Jedi Temple, Galactic City",
                    ContactNote = "Jedi Master"
                },
                new Contact
                {
                    ContactID = 3,
                    ContactName = "Sherlock Holmes",
                    ContactPhone = "555-221-2583",
                    ContactAddress = "221B Baker Street, London",
                    ContactNote = "Detective"
                }
            );
        }
    }
}