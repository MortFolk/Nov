using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_2.Models
{
    internal class Participant
    {
        public Participant()
        {
        }

        public Participant(string firstName, string lastName, string email)
         {
             FirstName = firstName;
             LastName = lastName;
             Email = email;
         }


        public Guid Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FullName => $"{FirstName} {LastName}";

    }
}
