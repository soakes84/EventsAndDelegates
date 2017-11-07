using System;
namespace DelegatesAndEvents
{
    public class PagerService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("PagerService: Sending a page.... " + args.Video.Title);
        }
    }
}
