using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Task1
{
    public class User
    {
        private static int _id = 0;
        private BindingList<Reward> _rewards = new BindingList<Reward>();
        
        public User(string firstName, string lastName, DateTime birthDay, BindingList<Reward> rewards)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            _rewards = rewards;
            Id = ++_id;
        }

        public int Id { get; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - BirthDay.Year;
            }
        }

        public string Rewards 
        { 
            get
            {
                if (_rewards is null)
                {
                    return "";
                }

                StringBuilder stringRewards = new StringBuilder();

                foreach (var reward in _rewards)
                {
                    stringRewards.Append(reward.Title);
                    stringRewards.AppendLine();
                }

                return stringRewards.ToString();
            }
        }

        public void AddReward(Reward reward)
        {
            _rewards.Add(reward);
        }

        public void RemoveReward(Reward reward)
        {
            _rewards.Remove(reward);
        }

        public bool IsRewardContains(Reward reward)
        {
            return _rewards.Contains(reward);
        }

        public BindingList<Reward> GetRewards()
        {
            return _rewards;
        }
    }
}
