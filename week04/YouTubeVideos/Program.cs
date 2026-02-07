using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Calamuchita campsite", "Laura Roas", 6 );
        video1.AddComment(new Comment("This place is amazing! I want to visit it!", "Jean"));
        video1.AddComment(new Comment("I went with my family and we loved it.", "Katy"));
        video1.AddComment(new Comment("I was there last year, I totally recommend it!", "Jim"));
        video1.AddComment(new Comment("Great info!", "Sara"));

        Video video2 = new Video("Anisacate river", "Laura Roas", 8);
        video2.AddComment(new Comment("The pictures are beautiful, thanks for sharing", "Jhon"));
        video2.AddComment(new Comment("I agree, that place is very peaceful.", "Rebecca"));
        video2.AddComment(new Comment("I was there last year, I totally recommend it!", "Tom"));

        Video video3 = new Video("Cordoba city","Laura Roas", 10);
        video3.AddComment(new Comment("I'll visit it on my next vacation", "James"));
        video3.AddComment(new Comment("I don't like the city that much; I prefer the mountains..", "Robert"));
        video3.AddComment(new Comment("The food there is fabulous.", "Wendy"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine(" - - -");
            video.DisplayVideoInfo();  
            video.DisplayAllComments();
        }




        
        

        


    }
}