using System;

namespace Delegates {
  
  public class PhotoFilters {
    public void ApplyBrightness(object photo) {
      Console.WriteLine("Applied brightness");
    }

    public void ApplyContrast(object photo) {
      Console.WriteLine("Applied contrast");
    }

    public void Resize(object photo) {
      Console.WriteLine("Resized photo");
    }
  }
}