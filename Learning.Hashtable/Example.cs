using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Hashtable
{
    public class Example
    {
        
        
        public static void Dictionary()
        {
            //Create a new dictionary of strings, with string keys.
            Dictionary<string, string> openWith = new();
            //Add some elements to the dictionary. There are no duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            //The Add method throws an exception if the new key is already in the dictionary.
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = 'txt' already exists.");
            }


            //The Item property is another name for the indexer, so you can omit its name when accessing elements
        }
    }
}
