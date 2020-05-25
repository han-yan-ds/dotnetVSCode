using System;

namespace EventHandling 
{
  class Program
  {
    public static void Main(string[] args)
    {
      var video = new Video("Video 1");
      var videoEncoder = new VideoEncoder();

      videoEncoder.Encode(video);
    }
  }
}
