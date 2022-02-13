//https://www.dofactory.com/net/decorator-design-pattern
using DemoLibrary;

// Create book
Book book = new Book("Worley", "Inside ASP.NET", 10);
book.Display();

// Create video
Video video = new Video("Spielberg", "Jaws", 23, 92);
video.Display();

// Make video borrowable, then borrow and display
Console.WriteLine("\nMaking video borrowable:");
Borrowable borrowvideo = new Borrowable(video);
borrowvideo.BorrowItem("Customer #1");
borrowvideo.BorrowItem("Customer #2");
borrowvideo.Display();

// Make book Downloadable, then download and display
Console.WriteLine("\nMaking book downloadable:");
Downloadable downloadableBook = new Downloadable(book,"www.bookies.com");
downloadableBook.DownloadItem();
downloadableBook.DownloadItem();
downloadableBook.Display();

// Make video borrowable Downloadable, then download and display
Console.WriteLine("\nMaking video downloadable:");
Downloadable downloadableVideo= new Downloadable(borrowvideo, "www.videoes.com");
downloadableVideo.DownloadItem();
downloadableVideo.DownloadItem();
downloadableVideo.Display();
// Wait for user
Console.ReadKey();
