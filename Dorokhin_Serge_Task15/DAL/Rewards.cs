using Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Rewards : IAccess<Reward>
    {
        private List<Reward> _rewards = new List<Reward>();

        public void Add(Reward obj)
        {
            if (obj is null)
            {
                throw new ArgumentException();
            }

            _rewards.Add(obj);
        }

        public bool Remove(Reward obj)
        {
            if (obj is null)
            {
                throw new ArgumentException();
            }
            
            return _rewards.Remove(obj);
        }

        public List<Reward> GetList()
        {
            return _rewards;
        }
    }
}
