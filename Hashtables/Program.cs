using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable openWith = new Hashtable();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            //new file - don't like it
            openWith["doc"] = "winword.exe";

            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
            }

            Console.WriteLine();
            foreach (DictionaryEntry de in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }


        }
    }
}