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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                ContactId = 1,
                Name = "Peter Parker",
                Phone = "609-773-9847",
                Address = "685 Kelly St, Queens, NY 11234",
                Note = " "
            },
                new Contact
                {
                    ContactId = 2,
                    Name = "Clark Kent",
                    Phone = "632-555-0108",
                    Address = "899 Thomas St, Smallville, KS, 68512",
                    Note = " "
                },

                new Contact
                {
                    ContactId = 3,
                    Name = "Steve Rogers",
                    Phone = "678-136-7092",
                    Address = "111 America Ln, America, America, 11111",
                    Note = " "
                }

            );
        }
    }
}
