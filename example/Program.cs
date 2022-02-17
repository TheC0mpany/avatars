using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            //                         ⬇ Base url where all images stored             ⬇ Generate random number    ⬇ extension
            string url = "https://github.com/TheC0mpany/avatars/raw/main/avatars/(" + new Random().Next(4729) + ").jpg";

            Console.WriteLine(url);

            Console.ReadLine();
        }
    }
}