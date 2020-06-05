using System;
using System.Threading;

namespace EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "title-1" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();

            videoEncoder.videoEncoded += mailService.OnVideoEncode; //subscribing event
            videoEncoder.videoEncoded += messageService.OnVideoEncode;
            videoEncoder.Encode(video);

        }
    }
    public class MessageService
    {
        //When define subscriber method is should be same as publisher delegate signature
        public void OnVideoEncode(Object source, EventArgs e)
        {
            Console.WriteLine("Message service sending message ...");
        }
    }
    public class MailService
    {
        //When define subscriber method is should be same as publisher delegate signature
        public void OnVideoEncode(Object source, EventArgs e)
        {
            Console.WriteLine("Mail service sending email...");
        }
    }
    public class VideoEncoder
    {
        //1.Define delegate with specified signature
        //2.Define event based on that delegate
        //3.Raise or publish the event

        //1.Define Delegate
       // public delegate void VideoEncoderEventHandler(object source, EventArgs args);
        
        //2.Define event based on delegate
        //public event VideoEncoderEventHandler videoEncoded;
        //2.1 Instead of custom delegate we can use builtin delegate called EventHandler
        public event EventHandler<EventArgs> videoEncoded;

        //3.Raise or publish event
        protected virtual void OnVideoEncoded()
        {
            if (videoEncoded != null)
                videoEncoded(this, EventArgs.Empty);

            //OR videoEncoded?.Invoke(this, EventArgs.Empty);
        }
        //Here our publiser is ready now create subscribers

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }
    }
    public class Video
    {
        public string Title { get; set; }
    }
}
