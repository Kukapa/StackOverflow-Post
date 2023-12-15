namespace StackOverflow
{
    public class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("Does my post work?", "Test to see if my post works.");
            Console.WriteLine($"Title: {post.Title}");
            Console.WriteLine($"Description: {post.Description}");
            Console.WriteLine($"Date Created: {post.TimeCreated}");
            Console.WriteLine($"Post Count: {post.Vote}");
            post.VoteDown();
            Console.WriteLine($"Post Count: {post.Vote}");
            post.VoteUp();
            Console.WriteLine($"Post Count: {post.Vote}");
        }
    }
}