using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //int[] mass = new int[] {1,2,3,4,5,6};
            //int n = mass.Length;
            //int k = n / 2;
            //int temp;
            //for(int i=0;i<n;i++)
            //{
            //    temp = mass[i];
            //    mass[i] = mass[n-i-1];
            //    mass[n-i-1] = temp;
            //}
            //foreach(int i in mass)
            //{
            //    Console.WriteLine($"mass[{i}]={i}");
            //}

            //2
            //int[] mass = new int[31];
            //Random random=new Random();
            //for(int i = 0; i < mass.Length; i++)
            //{
            //    mass[i] = random.Next(5,60);
            //    Console.WriteLine($"mass[{i}]={mass[i]}мм");
            //}
            //int summ = mass.Sum();
            //Console.WriteLine($"summ={summ}");

            //3
            //int[] mass = new int[20];
            //Random random = new Random();
            //for(int i=0;i<mass.Length;i++)
            //{
            //    mass[i] = random.Next(50,100);
            //    Console.WriteLine($"mass[{i}]={mass[i]}кг");
            //}
            //int summ = mass.Sum();
            //int sr = summ / 20;
            //Console.WriteLine($"sr={sr}");

            //4
            //int[] mass = new int[] {-37,0,50,46,34,46,-4,13};
            //int k = 0;
            //for(int i=0;i< mass.Length; i++)
            //{
            //    if (mass[i]<0)
            //    {
            //        k++;
            //    }
            //}
            //Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
