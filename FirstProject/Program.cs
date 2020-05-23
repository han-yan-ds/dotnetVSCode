﻿using System;

namespace Delegates
/*
* A System.Delegate is an object created using the delegate keyword (see PhotoProcessor.cs)
* This object has:
* 1) Target (what the delegate is running its functions on)
* 2) Method (typically something like () => function(target))
* 
* IMPORTANT: (A delegate is essentially a way to load methods)
*
* A delegate is converted to a System.MulticastDelegate when it gets a function added onto it (see "+=" below)
* A MulticastDelegate object has:
* 1) _invocationCount (# of functions assigned to it to run)
* 2) _invocationList (list of items similar to Method in System.Delegate)
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoFilters filters = new PhotoFilters();
            object photo = new object();

            // ProcessPhotoDelegate is a delegate in the PhotoProcessor class, assigned to a function
            PhotoProcessor.ProcessPhotoDelegate processPhoto = filters.ApplyBrightness;
            // delegates (such as processPhoto) can use the += operator to add another function to be run
            processPhoto += filters.ApplyContrast;
            // delegates can also use custom functions and lambda expressions
            processPhoto += (ph => Console.WriteLine("Removed Redeye"));

            // Now, run 3 functions (loaded onto Delegate) on photo
            processPhoto(photo);
        }
    }
}