using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// If a method needs to be available throughout the entire codebase,
// place it in the root namespace
namespace IntroToAsyncProgramming
{
    // Extension class must be static
    public static class StringExtensions
    {
        // Extension method must be static
        // First input parameter must be 'this' followed by the type that is being extended.
        public static string Shorten(this string input, int wordsToTake = 5)
        {
            string[] words = input.Split(' ');
            string[] selectedWords = words.Take(wordsToTake).ToArray();

            string result = string.Join(" ", selectedWords);

            return $"{result}...";
        }
    }
}
