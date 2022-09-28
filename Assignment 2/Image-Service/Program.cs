using System;
using System.IO;
using System.Threading;

namespace Image_Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Image Service Started");
            while (true)    
            {
                var flag = File.ReadAllText("/home/ozzy/CS361/Assignment 2/prng-service.txt");
                if (new FileInfo("/home/ozzy/CS361/Assignment 2/prng-service.txt").Length != 0 && flag != "run")
                {
                    Thread.Sleep(5000);
                    // Read number 
                    var randNum = File.ReadAllText("/home/ozzy/CS361/Assignment 2/prng-service.txt");
                
                    // Switch statement to write into image-service.txt
                    string imagePath;
                    switch (randNum)
                    {
                        case"1":
                            imagePath = "/home/ozzy/CS361/Assignment 2/Images/car1.jpg";
                            File.WriteAllText("/home/ozzy/CS361/Assignment 2/image-service.txt", imagePath);
                            break;
                        case"2":
                            imagePath = "/home/ozzy/CS361/Assignment 2/Images/car2.jpg";
                            File.WriteAllText("/home/ozzy/CS361/Assignment 2/image-service.txt", imagePath);
                            break;
                        case"3":
                            imagePath = "/home/ozzy/CS361/Assignment 2/Images/car3.jpg";
                            File.WriteAllText("/home/ozzy/CS361/Assignment 2/image-service.txt", imagePath);
                            break;
                        case"4":
                            imagePath = "/home/ozzy/CS361/Assignment 2/Images/car4.jpg";
                            File.WriteAllText("/home/ozzy/CS361/Assignment 2/image-service.txt", imagePath);
                            break;
                        case"5":
                            imagePath = "/home/ozzy/CS361/Assignment 2/Images/car5.jpg";
                            File.WriteAllText("/home/ozzy/CS361/Assignment 2/image-service.txt", imagePath);
                            break;
                        default:
                            continue;
                    }

                    break;
                }
            }
        }
    }
}