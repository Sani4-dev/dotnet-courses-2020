using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Reward
    {
        public Reward(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
