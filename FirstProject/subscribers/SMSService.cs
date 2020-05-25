using System;

namespace EventHandling
{
  public class SMSService
  {
    public void OnVideoEncoded(object source, EventArgs e) // note same signature enforced by delegate
    {
      Console.WriteLine("SMS Service: Text Message Sent");
    }
  }
}