using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Common;
using System.Collections.ObjectModel;

namespace BL
{
    public class UsersBL : IAccess<User>, IInit
    {
        private Users _users = new Users();

        public void Init()
        {
            _users.Add(new User("Alex", "Fintov", new DateTime(1980, 1, 1), new List<Reward>()));
            _users.Add(new User("Nicola", "Tesla", new DateTime(1983, 2, 2), new List<Reward>()));
            _users.Add(new User("Nikita", "Sklokov", new DateTime(1977, 3, 3), new List<Reward>()));
       }

        public void Add(User user)
        {
            if (user is null)
            {
                throw new ArgumentException();
            }
            
            _users.Add(user);
        }

        public bool Remove(User user)
        {
            if (user is null)
            {
                throw new ArgumentException();
            }
            
            return _users.Remove(user);
        }

        public List<User> GetList()
        {
            return _users.GetList();
        }
    }
}
