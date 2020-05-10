namespace Delegates {
  
  public class PhotoProcessor {
    
    public delegate void PhotoFilterHandler(object photo);

    public void Process(object photo, PhotoFilterHandler filterHandler) {
      filterHandler(photo);
    }
  } 
}