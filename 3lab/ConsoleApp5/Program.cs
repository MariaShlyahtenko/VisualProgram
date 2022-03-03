using System;

namespace RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                RomanNumber n1 = new RomanNumber(1000);
                RomanNumber n2 = new RomanNumber(1);
                RomanNumber n3 = new RomanNumber(2);
                RomanNumber n4 = new RomanNumber(3);
                RomanNumber n5 = new RomanNumber(150);
                RomanNumber n6 = new RomanNumber(555);

                Console.WriteLine("Сложение :");
                Console.WriteLine($"{n1.ToString()} + {n3.ToString()} = {(n1+ n3).ToString()} \n");

                Console.WriteLine("Вычитание :");
                Console.WriteLine($"{n6.ToString()} - {n5.ToString()} = {(n6-n5).ToString()} \n");

                Console.WriteLine("Умножение :");
                Console.WriteLine($"{n5.ToString()} * {n6.ToString()} = {(n5* n6).ToString()} \n");

                Console.WriteLine("Деление :");
                Console.WriteLine($"{n1.ToString()} / {n3.ToString()} = {(n1/ n3).ToString()} \n");

                RomanNumber[] mas = { n1, n2, n3, n4, n5, n6 };
                Array.Sort(mas);
                Console.WriteLine("Сортировка:");

                foreach (var num in mas)
                {
                    Console.WriteLine(num.ToString());
                }

            }

            catch (RomanNumberException exceptions)
            {
                Console.WriteLine($": {exceptions.Message}");
            }
        }
            
    }
}
