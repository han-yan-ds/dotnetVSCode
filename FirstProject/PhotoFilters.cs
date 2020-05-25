using System;

namespace Delegates {
  
  public class PhotoFilters {
    public void ApplyBrightness(object photo, int pct) {
      Console.WriteLine($"Applied brightness by {pct}%");
    }

    public void ApplyContrast(object photo, int pct) {
      Console.WriteLine($"Applied contrast by {pct}%");
    }

    public void Resize(object photo, int pct) {
      Console.WriteLine($"Resized photo by {pct}%");
    }
  }
}