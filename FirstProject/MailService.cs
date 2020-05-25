using System;

namespace EventHandling
{
  public class MailService
  {
    public void OnVideoEncoded(object source, EventArgs e)
    {
      Console.WriteLine("MailService: Email Sent");
    }
  }
}