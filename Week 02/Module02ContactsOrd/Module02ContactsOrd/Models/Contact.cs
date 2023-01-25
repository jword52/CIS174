using System.ComponentModel.DataAnnotations;

namespace Module02ContactsOrd.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string PhoneNum { get; set; }

        public string FriendId { get; set; }
        public ContactFriend ContactFriend { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + PhoneNum?.ToString();
    }
}
