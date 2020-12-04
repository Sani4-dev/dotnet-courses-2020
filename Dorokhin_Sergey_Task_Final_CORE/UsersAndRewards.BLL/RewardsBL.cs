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
    public class RewardsBL : IAccess<Reward>
    {
        private readonly IAccess<Reward> _rewards;

        public RewardsBL(IAccess<Reward> obj)
        {
            _rewards = obj;
        }
        
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
            _rewards.Update(reward);
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
            return _rewards.GetList();
        }
    }
}
