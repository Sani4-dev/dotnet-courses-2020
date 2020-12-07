using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Entites;
using UsersAndRewards.DAL;

namespace UsersAndRewards.BLL
{
    public class UsersBL : IAccess<User>
    {
        private readonly IAccess<User> _users;

        public UsersBL(IAccess<User> obj)
        {
            _users = obj;
        }

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
            _users.Update(user);
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
            return _users.GetList();
        }

        public List<User> Sort(int mode)
        {
            switch (mode)
            {
                case 1:
                    return GetList().OrderBy(u => u.Id).ToList();
                case 2:
                    return GetList().OrderBy(u => u.FirstName).ToList();
                case 3:
                    return GetList().OrderBy(u => u.LastName).ToList();
                case 4:
                    return GetList().OrderBy(u => u.DateBirthday).ToList();
                case 5:
                    return GetList().OrderBy(u => u.Age).ToList();
                default:
                    return GetList().OrderBy(u => u.Id).ToList();
            }
        }
    }
}
