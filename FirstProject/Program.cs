using System;

namespace EventHandling 
{
  class Program
  {
    public static void Main(string[] args)
    {
      var video = new Video("Video 1");
      var videoEncoder = new VideoEncoder(); // publisher
      var mailService = new MailService(); // subcription

      videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // registering a subscriber method to delegate
      videoEncoder.Encode(video);
    }
  }
}
