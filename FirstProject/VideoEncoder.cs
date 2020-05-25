using System;
using System.Threading;

namespace EventHandling
{
  public class VideoEncoder
  {
    /*
    * 1- Define a delegate (EventHandler is already a delegate)
    * 2- Define an event based on that delegate (EventHandler by default takes in 1st generic-type param as this object)
    * 3- Raise the event
    */

    public event EventHandler<EventArgs> VideoEncoded; // delegate + event based on that delegate

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