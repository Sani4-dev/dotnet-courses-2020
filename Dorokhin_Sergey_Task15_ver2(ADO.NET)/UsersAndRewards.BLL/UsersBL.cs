﻿using System;
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
        private readonly UsersSql _users;

        public UsersBL(string connectionString)
        {
            _users = new UsersSql(connectionString);
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
    }
}
