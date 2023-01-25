using Microsoft.EntityFrameworkCore;

namespace Module02ContactsOrd.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) 
            : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactFriend> Friends { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactFriend>().HasData(
                new ContactFriend { FriendId = "F", CName = "Friend" },
                new ContactFriend { FriendId = "B", CName = "Business" },
                new ContactFriend { FriendId = "A", CName = "Family" }
                );

            modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                ContactId = 1,
                Name = "Peter Parker",
                PhoneNum = "609-773-9847",
                FriendId = "F"
            },
            new Contact
            {
                ContactId = 2,
                Name = "Clark Kent",
                PhoneNum = "632-555-0108",
                FriendId = "B"
            },
            new Contact
            {
                ContactId = 3,
                Name = "Steve Rogers",
                PhoneNum = "678-136-7092",
                FriendId = "A"
            }
            );
        }
    }
}
