using System;
using System.IO;
using System.Threading;

namespace PRNG_Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PRNG Service Started");
            while (true)
            {
                string flag = File.ReadAllText("/home/ozzy/CS361/Assignment 2/prng-service.txt");
                if (flag == "run")
                {
                    Thread.Sleep(5000);
                    
                    File.WriteAllText("/home/ozzy/CS361/Assignment 2/prng-service.txt", string.Empty);

                    Random rnd = new Random();
                    int num = rnd.Next(1, 5);
                    
                    File.WriteAllText("/home/ozzy/CS361/Assignment 2/prng-service.txt", num.ToString());
                    
                    break;
                }
            }
        }
    }
}