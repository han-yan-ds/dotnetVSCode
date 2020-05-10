using System.Collections.Generic;

namespace dotnetVSCode 
{
  public class Queue<T> 
  {

    private List<T> list;

    public Queue() {
      list = new List<T>();
    }

    public void Enqueue(T item) {
      list.Add(item);
    }

    public T Dequeue() {
      T lastItem = list[0];
      list.RemoveAt(0);
      return lastItem;
    }

  }
}