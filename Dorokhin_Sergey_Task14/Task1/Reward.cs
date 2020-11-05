namespace Task1
{
    public class Reward
    {
        private static int _id = 0;

        public Reward(string title, string description)
        {
            Title = title;
            Description = description;
            Id = ++_id;
        }

        public int Id { get; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
