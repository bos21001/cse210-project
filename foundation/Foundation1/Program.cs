namespace Foundation1;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", 60);
        Video video2 = new Video("Video 2", "Author 2", 120);
        Video video3 = new Video("Video 3", "Author 3", 180);
        
        foreach (Video video in new Video[] { video1, video2, video3 })
        {
            video.AddComment(new Comment("Commenter 1", "Text 1"));
            video.AddComment(new Comment("Commenter 2", "Text 2"));
            video.AddComment(new Comment("Commenter 3", "Text 3"));
        }
        
        Video[] videos = new Video[] { video1, video2, video3 };
        
        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine(video.DisplayDetails());
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine(comment.DisplayComment());
            }
            Console.WriteLine($"Comment count: {video.GetCommentCount()}");
        }
        
    }
}