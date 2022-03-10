using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication5.Models
{
    public class RomanNumberExtend : RomanNumber
    {
        public static ushort ToInt(string num)
        {


            num = new string(num.Reverse().ToArray());
            ushort intt = 0;
            for (int i = 0; i < num.Length; i++)
            {
                switch (num[i])
                {
                    case 'M':
                        intt += 1000;
                        break;
                    case 'D':
                        intt += 500;
                        break;
                    case 'C':
                        intt += 100;
                        if (i > 0)
                        {
                            if (num[i - 1] == 'M' || num[i - 1] == 'D')
                            {
                                intt -= 200;
                            }
                        }
                        break;
                    case 'L':
                        intt += 50;
                        break;
                    case 'X':
                        intt += 10;
                        if (i > 0)
                        {
                            if (num[i - 1] == 'C' || num[i - 1] == 'L')
                            {
                                intt -= 20;
                            }
                        }
                        break;
                    case 'V':
                        intt += 5;
                        break;
                    case 'I':
                        intt += 1;
                        if (i > 0)
                        {
                            if (num[i - 1] == 'X' || num[i - 1] == 'V')
                            {
                                intt -= 2;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            return intt;
        }
        public RomanNumberExtend(string num) : base(ToInt(num)) { }
    }
}