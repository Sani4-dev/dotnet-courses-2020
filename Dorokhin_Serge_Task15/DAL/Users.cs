using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class Users : IAccess<User>
    {
        private List<User> _users = new List<User>();

        public void Add(User obj)
        {
            if (obj is null)
            {
                throw new ArgumentException();
            }
            
            _users.Add(obj);
        }

        public bool Remove(User obj)
        {
            if (obj is null)
            {
                throw new ArgumentException();
            }
            
            return _users.Remove(obj);
        }

        public List<User> GetList()
        {
            return _users;
        }
    }
}
