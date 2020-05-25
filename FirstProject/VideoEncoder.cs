using System;
using System.Threading;

namespace EventHandling
{
  class VideoEncoder
  {
    public Action<Event>;

    public void Encode(Video video)
    {
      Console.WriteLine("Encoding Video, wait 3 seconds...");
      Thread.Sleep(3000);
      Console.WriteLine("Done Encoding!");
    }
  }
}