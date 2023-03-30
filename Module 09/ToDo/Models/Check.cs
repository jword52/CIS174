using System.Linq;
using ToDoApp.Data;
using ToDoApp.Models;

namespace ToDoApp.Models
{
    public static class Check
    {
        public static string EmailExists(TicketContext context, string email)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(email))
            {
                var user = context.Users.FirstOrDefault(
                    c => c.EmailAddress.ToLower() == email.ToLower());
                if (user != null)
                    msg = $"Email address {email} already in use.";
            }
            return msg;
        }
    }
}