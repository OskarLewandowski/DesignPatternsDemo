using System;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //with not caching 
            Console.WriteLine("No caching");
            YouTubeService youTubeService = new YouTubeService();
            youTubeService.GetVideo(10);
            youTubeService.GetVideo(11);
            youTubeService.GetVideo(10);
            youTubeService.GetVideo(10);
            youTubeService.GetVideo(11);

            Console.WriteLine("\nCaching");
            //with caching 
            ProxyYouTubeService proxyYouTubeService = new ProxyYouTubeService(youTubeService);
            proxyYouTubeService.GetVideo(10);
            proxyYouTubeService.GetVideo(11);
            proxyYouTubeService.GetVideo(10);
            proxyYouTubeService.GetVideo(10);
            proxyYouTubeService.GetVideo(11);

            Console.ReadLine();
        }
    }
}
