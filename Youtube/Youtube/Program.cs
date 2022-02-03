using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;
using VideoLibrary;
namespace Youtube
{
    class Program
    {


        static void Main(string[] args)
        {
            DisplayIntro();
            VideoInfo();

        }

        public static async Task VideoInfo()
        {

            Console.WriteLine("Youtube Video Link:");
            string Link = Console.ReadLine();
            var youTube = YouTube.Default;
            var video = youTube.GetVideo(Link);
            string title = video.Title;
            
            Console.WriteLine("=========================================");
            Console.WriteLine("=         1)DownloadAudio               =");
            Console.WriteLine("=         2)DownloadVideo               =");
            Console.WriteLine("=========================================");

            string choice = Console.ReadLine();
            if (Convert.ToInt32(choice) == 1)
            {
                string fullname = title + ".mp3";
                byte[] bytes = video.GetBytes();
                var stream = video.Stream();
                File.WriteAllBytes(@"C:\Users\MY-PC\Desktop\music" + fullname, bytes);
            }
            if(Convert.ToInt32(choice) == 2)
            {
                string fullname = title + ".mp4";
                byte[] bytes = video.GetBytes();
                var stream = video.Stream();
                File.WriteAllBytes(@"C:\Users\MY-PC\Desktop\music" + fullname, bytes);
            }


        }
        public static void DisplayIntro()
        {

            Console.WriteLine("=========================================");
            Console.WriteLine("=         Youtube Video Downloader      =");
            Console.WriteLine("=             Spoonkid                  =");
            Console.WriteLine("=========================================");
        }

    }
}
