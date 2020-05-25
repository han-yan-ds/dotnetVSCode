using System;

namespace EventHandling
{
  public class MailService
  {
    public void OnVideoEncoded(object source, EventArgs e) // note same signature enforced by delegate
    {
      Console.WriteLine("Mail Service: Email Sent");
    }
  }
}