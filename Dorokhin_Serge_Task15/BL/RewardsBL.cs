using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Collections.ObjectModel;

namespace BL
{
    public class RewardsBL : IAccess<Reward>, IInit
    {
        private Rewards _rewards = new Rewards();

        public void Init()
        {
            _rewards.Add(new Reward("Reward 1", "The first reward"));
            _rewards.Add(new Reward("Reward 2", "The second reward"));
            _rewards.Add(new Reward("Reward 3", "Simple reward"));
        }

        public void Add(Reward reward)
        {
            if (reward is null)
            {
                throw new ArgumentException();
            }
            
            _rewards.Add(reward);
        }

        public bool Remove(Reward reward)
        {
            if (reward is null)
            {
                throw new ArgumentException();
            }

            return _rewards.Remove(reward);
        }

        public List<Reward> GetList()
        {
            return _rewards.GetList();
        }
    }
}
