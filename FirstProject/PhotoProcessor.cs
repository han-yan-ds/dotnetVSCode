namespace Delegates {
  
  public class PhotoProcessor {
    
    // this delegate object allows methods to be loaded onto it, then executed
    // see Main function in Program.cs for how this works
    public delegate void ProcessPhotoDelegate(object photo);
  } 
}