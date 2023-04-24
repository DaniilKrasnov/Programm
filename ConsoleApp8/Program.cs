using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //int a = 0;
            //Random random = new Random();
            //for(int i=1;i<10;i++)
            //{
            //   a=random.Next(-40,40);
            //    Console.WriteLine(a);
            //}
            //2
            //double a = 0;
            //int b = 0;
            //Random r = new Random();
            //for(int i=1;i<15;i++)
            //{
            //    a = r.Next(-20,30);
            //    Console.WriteLine(a);
            //    if(a>0)
            //    {
            //        b++;
            //    }
            //}
            //Console.WriteLine("b="+b);
            //3
            double a = 0;
            Random r = new Random();
            for(int i=1;i<=12;i++)
            {
                a = r.Next(-5,5);
                Console.WriteLine(a);
                if(a<0)
                {
                    Console.WriteLine($"{a}-отрицательное");
                }
                if(a>0)
                {
                    Console.WriteLine($"{a}-положительное");
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
            Console.ReadKey();
        }
    }
}
