using System;
using System.Threading;
namespace DelegatesAndEvents
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video....");
            Thread.Sleep(2500);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)         //always start name with 'On'
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(){Video = video});   
            
        }
    }
}
