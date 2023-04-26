using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.Write("Введите количество элементов массива: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //Random rnd = new Random();

            //// Заполнение массива случайными значениями от 1 до 80
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(1, 81);
            //}

            //// Вывод массива на экран
            //Console.WriteLine("Исходный массив:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}
            //Console.WriteLine();

            //// Нахождение минимального и максимального элементов
            //int min = arr[0], max = arr[0];
            //int minIndex = 0, maxIndex = 0;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //        minIndex = i;
            //    }
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        maxIndex = i;
            //    }
            //}

            //Console.WriteLine($"Минимальный элемент: {min}");
            //Console.WriteLine($"Максимальный элемент: {max}");

            //// Обмен минимального и максимального элементов
            //int temp = arr[minIndex];
            //arr[minIndex] = arr[maxIndex];
            //arr[maxIndex] = temp;

            //// Вывод измененного массива на экран
            //Console.WriteLine("Измененный массив:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}
            //Console.WriteLine();

            //2
            //double[] array = new double[12];
            //Random rand = new Random();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rand.NextDouble() * 100; // заполнение массива случайными значениями
            //    Console.Write("{0:f2} ", array[i]);
            //}

            //Array.Sort(array); // сортировка массива по возрастанию
            //Array.Reverse(array); // обратный порядок

            //Console.WriteLine("\nМассив в порядке убывания:");

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("{0:f2} ", array[i]);
            //}

            //double min = array[array.Length - 1]; // находим минимальный элемент
            //double max = array[0]; // находим максимальный элемент

            //Console.WriteLine("\nСумма максимального и минимального элементов: {0:f2}", min + max);
            //3
                //double[] array = new double[14];
                //Random rand = new Random();

                //for (int i = 0; i < array.Length; i++)
                //{
                //    array[i] = rand.NextDouble() * 100; // заполнение массива случайными значениями
                //    Console.Write("{0:f2} ", array[i]);
                //}

                //Array.Sort(array, 0, 7); // сортировка первых 7 элементов по возрастанию
                //Array.Reverse(array, 7, 7); // сортировка последних 7 элементов по убыванию

                //Console.WriteLine("\nМассив с 1 по 7 элемент в порядке возрастания, с 8 по 14 в порядке убывания:");

                //for (int i = 0; i < array.Length; i++)
                //{
                //    Console.Write("{0:f2} ", array[i]);
                //}

                Console.ReadKey();
            
        }

    }
}




