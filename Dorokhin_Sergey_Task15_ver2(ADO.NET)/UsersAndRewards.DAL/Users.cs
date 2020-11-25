using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites;

namespace UsersAndRewards.DAL
{
    public class Users : IAccess<User>
    {
        private List<User> _users = new List<User>();

        public void Add(User user)
        {
            if (user is null)
            {
                throw new ArgumentException();
            }
            
            _users.Add(user);
        }

        public void Update(User user)
        {
            if (user is null)
            {
                throw new ArgumentException();
            }
        }

        public void Remove(User user)
        {
            if (user is null)
            {
                throw new ArgumentException();
            }
            
            _users.Remove(user);
        }

        public List<User> GetList()
        {
            return _users;
        }
    }
}
