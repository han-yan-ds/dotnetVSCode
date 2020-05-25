using System;

namespace EventHandling 
{
  class Program
  {
    public static void Main(string[] args)
    {
      var video = new Video("Video 1");
      var videoEncoder = new VideoEncoder(); // publisher... has delegate
      var mailService = new MailService(); // subcription
      var smsService = new SMSService();

      videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // registering a subscriber method to delegate
      videoEncoder.VideoEncoded += smsService.OnVideoEncoded;

      videoEncoder.Encode(video);
    }
  }
}
