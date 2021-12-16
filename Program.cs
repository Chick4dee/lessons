using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lessons
{
    class Program
    {
        

        static void res(ref int[] F, ref int[] C)
        {
            int resultF = F.Min() + F.Max();
            Console.WriteLine(resultF);
            int resultC = C.Min() + C.Max();
            Console.WriteLine(resultC);
        }
        
        public static void Main(string[] args)
        {
            int[] F = new int[16];
            int[] C = new int[20];
            
            Console.WriteLine("Введите данные массива, до 16 чисел");
            for (int i = 0; i < F.Length; i++)
            {
                F[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Массив F заполнен");

            Console.WriteLine("Введите данные массива, до 20 чисел");
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Массив С заполнен");
            res(ref F, ref C);
            
        }        
    }
}