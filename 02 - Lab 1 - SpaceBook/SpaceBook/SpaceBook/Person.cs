using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBook
{
    public class Person
    {
        private readonly string _username;
        public List<Person> Friends
        {
            get;
            private set;
        }

        public Person(string username)
        {
            ValidateUsername(username);
            _username = username;
            Friends = new List<Person>();
        }

        private void ValidateUsername(string username)
        {
            if (IllegalUsername(username))
            {
                throw new ArgumentNullException("Username cannot be null or empty");
            }
        }

        private bool IllegalUsername(string username)
        {
            return username == null || username.Trim().Length < 1;
        }

        public void BecomeFriendWith(Person person)
        {
            if (this == person)
            {
                throw new ArgumentException("Are you so lonely?");
            }

            person.Friends.Add(this);
            Friends.Add(person);
        }
    }
}
