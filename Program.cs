using System;
using System.Collections.Generic;
using System.IO;



namespace Example
{
    public class Point3D
    { 
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

    };

    class Program
    { 
        static string task19 (int num)
        {
            string result = "not a poly";
            String str = Convert.ToString(num);
            if(str.Length == 5)
            {
                 if ((str[0] == str[4]) && (str[1] == str[3]))
                 {
                    result = "yes";
                 }

            }
            else
            {
                Console.WriteLine("value don't have 5 numbers");
            }

            return result;
        }
        static double task21(Point3D point1, Point3D point2)
        {
            double delta = Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2) + Math.Pow((point2.Z - point1.Z), 2));

            return Math.Round(delta,3);

        }

        static void task23 (int n)
        {
            
            String tmp = "";
            
            
            for (int i = 1; i < n;)
            {                
                tmp += Math.Pow(i,3) + "  " ;
           
                i++;
            }
            Console.WriteLine(tmp);

        }



        static void Main(string[] args)
        {  
            Console.WriteLine("task19");
            Console.WriteLine("Enter five-digit number ");
            int num = int.Parse((Console.ReadLine()));
            Console.WriteLine(task19(num));


            Console.WriteLine("task21");
            Point3D p1 = new Point3D();
            Console.WriteLine("Enter point one ");
            p1.X = int.Parse((Console.ReadLine()));
            p1.Y = int.Parse((Console.ReadLine()));
            p1.Z = int.Parse((Console.ReadLine()));

            Point3D p2 = new Point3D();
            Console.WriteLine("Enter point two ");
            p2.X = int.Parse((Console.ReadLine()));
            p2.Y = int.Parse((Console.ReadLine()));
            p2.Z = int.Parse((Console.ReadLine()));
            Console.WriteLine(task21(p1, p2));
            
            
            Console.WriteLine("task23");
            Console.WriteLine("Enter  number ");
            int n = int.Parse((Console.ReadLine()));
            task23(n);     

        
            
        }
    }
}
