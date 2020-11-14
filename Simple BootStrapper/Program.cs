using System.Diagnostics;
using System.Net;
using System;

namespace Simple_BootStrapper
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red; // chnages color
            Console.WriteLine("This program must be run as an administrator!!!");

            Console.ForegroundColor = ConsoleColor.Blue; // chnages color
            Console.WriteLine("Simple BootStrapper Made By Water1597 on github");

            Console.ForegroundColor = ConsoleColor.Green; // chnages color
            System.Console.WriteLine("Press any key to Boot Program");
            System.Console.ReadKey(true); // reads if a key is pressed

            Console.ForegroundColor = ConsoleColor.Red; // chnages color
            Console.Clear(); // clears console
            Console.WriteLine("Downloading At C:\\Program Files\\Program.exe");

            Console.ForegroundColor = ConsoleColor.Green; // chnages color
            WebClient wb = new WebClient();
            string mainpath = "C:\\Program Files\\Program.exe";
            wb.DownloadFile(" LINK HERE ", mainpath); // Please put a download link in the "" for EX: "cdn.discord.gg/Program.exe"

            Console.WriteLine("Downloaded at C:\\Program Files\\Program.exe");
            Console.ForegroundColor = ConsoleColor.Blue; // chnages color
            Console.WriteLine("Starting Program");

            Process.Start("C:\\Program Files\\Program.exe");


            Console.Clear(); // clears console
            Console.WriteLine("Loaded Program");
            Console.WriteLine("Press any key to exit");
            System.Console.ReadKey(true); // reads if a key is pressed
        }
    }
}
