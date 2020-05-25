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

    public delegate void VideoEncodedEventHandler(object source, EventArgs e); // delegate
    public event VideoEncodedEventHandler VideoEncoded; // event based on that delegate

    protected virtual void OnVideoEncoded() // event publisher (notifies event subscribers)
    {
      if (VideoEncoded != null) VideoEncoded(this, EventArgs.Empty);
    }

    public void Encode(Video video)
    {
      Console.WriteLine("Encoding Video, wait 3 seconds...");
      Thread.Sleep(3000);
      OnVideoEncoded(); // runs event publisher
    }
  }
}