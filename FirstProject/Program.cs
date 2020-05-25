using System;

namespace Delegates
/*
* This is an example of how to use the Action built-in delegate in .NET
* 
* Func is also a built-in delegate, but Func returns a value; Action doesn't.
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoFilters filters = new PhotoFilters();
            object photo = new object();

            Action<object, int> processPhoto = filters.ApplyBrightness;
            processPhoto += filters.ApplyContrast;
            processPhoto += ((ph, pct) => Console.WriteLine($"Removed Redeye by {pct}%"));

            // Now, run 3 functions (loaded onto Delegate) on photo
            processPhoto(photo, 4);
        }
    }
}