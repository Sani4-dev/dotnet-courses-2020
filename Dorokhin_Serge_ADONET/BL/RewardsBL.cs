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
    public class RewardsBL : IAccess<Reward>
    {
        private readonly RewardsSql _rewards;

        public RewardsBL(string connectionString)
        {
            _rewards = new RewardsSql(connectionString);
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
