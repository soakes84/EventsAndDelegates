using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService();  //subscriber
            var messageService = new MessageService(); //another subscriber
            var pagerService = new PagerService();    //subscriber 

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //not invoking method here, just a reference/pointer to the method
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VideoEncoded += pagerService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
