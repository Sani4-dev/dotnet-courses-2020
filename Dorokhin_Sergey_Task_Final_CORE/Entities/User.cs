using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class User
    {
        public User(int id, string firstName, string lastName, DateTime dateBirthday, List<Reward> rewards)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateBirthday = dateBirthday;
           Rewards = rewards;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateBirthday { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateBirthday.Year;
            }
        }

        public List<Reward> Rewards { get; set; }

        public string RewardsAsString
        {
            get
            {
                if (Rewards is null)
                {
                    return string.Empty;
                }
                else
                {
                    if (Rewards.Count > 0)
                    {
                        var sb = new StringBuilder();

                        for (int i = 0; i < Rewards.Count; i++)
                        {
                            if (Rewards[i] != null)
                            {
                                sb.Append(Rewards[i].Title);

                                if (i != Rewards.Count - 1)
                                {
                                    sb.AppendLine();
                                }
                            }   
                        }

                        return sb.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
        }

    }
}
