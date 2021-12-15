using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_2
{
    public class User
    {
        public User()
        {
         
        }
        public User( string firstName, string email, string lastName)
        {
            this.id = id;
            FirstName = firstName;
            Email = email;
            LastName = lastName;
        }

        public Guid id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = "";
        public string Email { get; set; } = "";
        public string LastName { get; set; } = "";

        public string FullName => $"{FirstName} {LastName}";

     

    }
}
