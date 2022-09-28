using System;
using System.IO;
using System.Threading;

namespace UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 'x' to generate random image path. Enter any character to quit.");
            var input = Console.ReadLine();
            if (input != "x") return;
            
            // Set run flag 
            File.WriteAllText("/home/ozzy/CS361/Assignment 2/prng-service.txt", "run");
            
            while (true)
                if (File.ReadAllText("/home/ozzy/CS361/Assignment 2/prng-service.txt") != "run" 
                    && new FileInfo("/home/ozzy/CS361/Assignment 2/prng-service.txt").Length != 0)
                {
                    string randNum = File.ReadAllText("/home/ozzy/CS361/Assignment 2/prng-service.txt");
                    
                    // Copy random number into image-service.txt
                    File.WriteAllText("/home/ozzy/CS361/Assignment 2/image-service.txt", randNum);

                    Thread.Sleep(10000);

                    //Read image path and display to user
                    string path = File.ReadAllText("/home/ozzy/CS361/Assignment 2/image-service.txt");
                    Console.WriteLine(path);

                    // Clear files
                    File.WriteAllText("/home/ozzy/CS361/Assignment 2/prng-service.txt", string.Empty);
                    File.WriteAllText("/home/ozzy/CS361/Assignment 2/image-service.txt", string.Empty);

                    break;
                }
        }
    }
}