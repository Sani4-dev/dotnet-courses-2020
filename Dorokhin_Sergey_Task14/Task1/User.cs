using System;

namespace Task1
{
    public class User
    {
        private static int _id = 0;
        
        public User(string firstName, string lastName, DateTime birthDay)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Id = ++_id;
        }

        public int Id { get; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - BirthDay.Year;
            }
        }
    }
}
