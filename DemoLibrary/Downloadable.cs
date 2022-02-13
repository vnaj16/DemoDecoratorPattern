using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Downloadable : Decorator
    {
        public Downloadable(LibraryItem libraryItem, string url) : base(libraryItem)
        {
            Url = url;
            NumberOfDownloads = 0;
        }

        public string Url { get; set; }
        public int NumberOfDownloads { get; set; }
        public void DownloadItem()
        {
            Console.WriteLine($"Downloading from {Url}....");
            NumberOfDownloads++;
        }
        
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Number of Downloads: " + NumberOfDownloads);
            Console.WriteLine("Download from: " + Url);
        }

    }
}
