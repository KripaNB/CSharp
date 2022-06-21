using System;

namespace Exercise23
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; private set; }
        public DateTime DateCreated = DateTime.Now;
        public int Votes { get; set; }

        public Post(string title, string description)
        {
            if (String.IsNullOrWhiteSpace(title) || String.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The title/description cannot be null, empty or whitespace.");

            Title = title.Trim();
            Description = description.Trim();
        }

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            Votes--;
        }
    }
}
