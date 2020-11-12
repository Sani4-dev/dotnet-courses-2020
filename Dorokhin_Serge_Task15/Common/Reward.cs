using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Reward
    {
        private static int _id = 0;
        
        public Reward(string title, string description)
        {
            Id = ++_id;
            Title = title;
            Description = description;
        }

        public int Id { get; }

        public string Title { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
