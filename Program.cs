using System;
using System.IO;

namespace Genomgångar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Lektion 1 typ eller nåt

            // File.WriteAllText("words.txt", "hey hopp här finns det text");

            /*string s = File.ReadAllText("words.txt");

            Console.WriteLine(s);
            Console.ReadLine();    */

            // string[] words = {"hey", "ho", "hipp", "hopp"};
            // File.WriteAllLines("words.txt", words);

            if(File.Exists("words.txt"))
            {
            string[] words = File.ReadAllLines("words.txt");
            System.Console.WriteLine(words[0]);

            }


            
            
            
            Console.ReadLine();


        }
    }
}
