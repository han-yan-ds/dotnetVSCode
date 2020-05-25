using System;
using System.Threading;

namespace EventHandling
{
  public class VideoEncoder
  {
    /*
    * 1- Define a delegate
    * 2- Define an event based on that delegate
    * 3- Raise the event
    */

    public Action<object, EventArgs> VideoEncodedEventHandler; // delegate, determines function signature of subscribers
    public event VideoEncodedEventHandler VideoEncoded; // event based on that delegate

    public void Encode(Video video)
    {
      Console.WriteLine("Encoding Video, wait 3 seconds...");
      Thread.Sleep(3000);
    }

    protected virtual void OnVideoEncoded() // event publisher (notifies event subscribers)
    {
      if (VideoEncoded != null) VideoEncoded(this, EventArgs.Empty);
    }
  }
}