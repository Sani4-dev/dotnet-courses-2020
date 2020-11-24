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

        public void Add(Reward reward)
        {
            if (reward is null)
            {
                throw new ArgumentException();
            }

            _rewards.Add(reward);
        }

        public void Update(Reward reward)
        {
            if (reward is null)
            {
                throw new ArgumentException();
            }
        }

        public void Remove(Reward reward)
        {
            if (reward is null)
            {
                throw new ArgumentException();
            }
            
            _rewards.Remove(reward);
        }

        public List<Reward> GetList()
        {
            return _rewards;
        }
    }
}
