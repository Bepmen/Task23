using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task23._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Разработать асинхронный метод для вычисления факториала числа. 
            В методе Main выполнить проверку работы метода.

             */

            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            FactorialAsync(n);

            Console.ReadKey();

        }
        static void Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i < n+1; i++)
            {
                f *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(f);
        }
        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }


    }
}
