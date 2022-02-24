using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RomanNumbers
{
    internal class RomanNumber : ICloneable, IComparable
    {

        private ushort sumb;
        private static int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static string[] roman = new string[]
            { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        //Конструктор получает представление числа n в римской записи
        public RomanNumber(ushort n)
        {
            if (n <= 0) throw new RomanNumberException($"Число {n} < либо = 0");
            else this.sumb = n;
        }
      
        public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
        {
            int num = n1.sumb + n2.sumb;
            if (num <= 0) throw new RomanNumberException("ERROR !Невозможно сложить  числа!");
            else
            {
                RomanNumber result = new((ushort)num);
                return result;
            }
        }

        public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
        {
            int num = n1.sumb - n2.sumb;
            if (num <= 0) throw new RomanNumberException("ERROR ! Результат вычитания < либо = 0!");
            else
            {
                RomanNumber result = new((ushort)num);
                return result;
            }
        }

        public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
        {
            int num = n1.sumb * n2.sumb;
            if (num <= 0) throw new RomanNumberException("ERROR ! Невозможно умножить 2 числа!");
            else
            {
                RomanNumber result = new((ushort)num);
                return result;
            }
        }
  
        public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
        {

            if (n2.sumb == 0) throw new RomanNumberException("ERROR ! Ошибка деления!");
            else
            {
                int num = n1.sumb / n2.sumb;
                if (num == 0) throw new RomanNumberException("ERROR ! Ошибка деления!");
                else
                {
                    RomanNumber result = new((ushort)num);
                    return result;
                }
            }
        }
     
        public override string ToString()
        {
            int tmp = sumb;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 13; i++)
            {
                while (tmp >= values[i])
                {
                    tmp -= (ushort)values[i];
                    result.Append(roman[i]);
                }
            }
            if (result.ToString() == "")
                throw new RomanNumberException("Невозможно перевести");
            else
                return result.ToString();

        }

        public object Clone()
        {
            return new RomanNumber(sumb);
        }

        public int CompareTo(object obj)
        {
            if (obj is RomanNumber roman)
                return sumb.CompareTo(roman.sumb);
            else
                throw new RomanNumberException("не RomanNumber");
        }

    }

}