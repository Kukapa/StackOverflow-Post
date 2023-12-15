namespace StackOverflow
{
    public class Post
    {
        public string Title{ get; set; }
        public string Description { get; set; }
        public DateTime TimeCreated { get; set; }
        public int Vote{ get; set; }
        private bool HasVotedUp;
        private bool HasVotedDown;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            TimeCreated = DateTime.Now;
            Vote = 1;
        }

        public void VoteUp()
        {
            if (HasVotedUp)
                throw new Exception("You've already up voted");
            else
                Vote++;
            HasVotedUp = true;
            HasVotedDown = false;
        }

        public void VoteDown()
        {
            if (HasVotedDown)
                throw new Exception("You've already down voted");
            else
                Vote--;
            HasVotedUp = true;
            HasVotedDown = false;
        }
    }
}