using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        Comment comment1 = new Comment ("Russel Young", "It's incredible the opportunity that we have to have the book of mormon in our current days! ");
        Comment comment2 = new Comment ("Daniel Morley", "I didn't know if this book was truly, but I prayed and got my answer. It is real! ");
        Comment comment3 = new Comment ("Yan Taylor", "Through this book I receive the daily strenght that I need to face my challenges. ");
        Comment comment4 = new Comment ("Christina Peace", "I believe that Joseph truly saw God and Jesus Christ in that day.");
        Comment comment5 = new Comment ("Rebecca Grow", "I know that God can answer my prayers because He answered a simple boy.");
        Comment comment6 = new Comment ("Jeff Power", "I know that he was a prophet of God");
        Comment comment7 = new Comment ("Cinthia Huge", "We are very blessed for this act of love");
        Comment comment8 = new Comment ("May Clint", "He loves all of us, He knows each one of us individually and because of Him, we can return to our heavenly home through the gospel of Jesus Christ");
        Comment comment9 = new Comment ("Samuel Jonathan", "He is our savior, I know and feel that!");



        _videos.Add(new Video("The Power of the Book of Mormon", "Peter F. Koch",12.45,[comment1, comment2, comment3]));
        _videos.Add(new Video("The First Vision", "Newell Clark",15.15,[comment4, comment5, comment6]));
        _videos.Add(new Video("Jesus Christ and His atonement", "Bruce Warden",08.05,[comment7, comment8, comment9]));

        foreach (var video in _videos)
        {
        video.Numberofcomments();
        Console.WriteLine();
        }
    }
}