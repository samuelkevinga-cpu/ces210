using System;

class Program
{
    static void Main(string[] args)
    {
        List <Video> videos = new List<Video>();

        //Video 1
        Video video1 = new Video("Counting to 1,000,000", "Mr beast", 10000);
        videos.Add(video1);
        //Comments of video 1
        Comment comment1 = new Comment("John","That's crazyyyyyyyy!!");
        video1.AddComment(comment1);
        
        Comment comment2 = new Comment("Marrie99","Yooooooo!!");
        video1.AddComment(comment2);

        Comment comment3 = new Comment("Master68","I hate you (wothout ofending you)");
        video1.AddComment(comment3);

        //Video 2
        Video video2 = new Video("How to solve a rubik cube", "Mr Cube", 5000);
        videos.Add(video2); 
        //Comments in video 2
        Comment comment21 = new Comment("ernikd","I still don't know");
        video2.AddComment(comment21);

        Comment comment22 = new Comment("the yester","Snooppp doggggg");
        video2.AddComment(comment22);

        Comment comment23 = new Comment("sampls","Toooo easyyyy");
        video2.AddComment(comment23);
        //Video 3
        Video video3 = new Video("Functions and classes in C#", "DevTools", 11000);
        videos.Add(video3);
        //Comments in video 3 (Im' tired :(  )
        Comment comment31 = new Comment("Ayub","Im rich bruh, i dont need this");
        video3.AddComment(comment31);

        Comment comment32 = new Comment("Elias43","excellent, now i learn a lot");
        video3.AddComment(comment32);
        
        Comment comment33 = new Comment("awww88","First start, first code");
        video3.AddComment(comment33);
        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Lenght : {video.GetLenght()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments: ");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"-{comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}   