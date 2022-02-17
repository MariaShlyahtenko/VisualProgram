using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {    int[] cash_reg = new int[n];
      
        int mini = 0;
      
        for (int i = 0; i < n; i++)
        {
            cash_reg[i] = 0;
        }
       for(int i=0; i < n; i++)
        {
            cash_reg[i] = customers[i];

        }
        int min =cash_reg[0];
        int max = cash_reg[0];
        for (int i = 0; i < n; i++)
        {
               
            if (cash_reg[i] <min)
            {
                min = cash_reg[i];
                mini = i;
            }

        }
        for (int i=n; i< customers.Length; i++)
        {
            cash_reg[mini] += customers[i];
            min = cash_reg[mini];
            for (int j = 0; j < n; j++)
            {

                if (cash_reg[j] < min)
                {
                    min = cash_reg[j];
                    mini = j;
                }

            }
        }
        for (int i = 0; i < n; i++)
        {

            if (cash_reg[i] > max)
            {
                max = cash_reg[i];
                
            }

        }
        return max;
    }
}



class Program
{
    static void Main(string[] args)
    {
     
        long rezult;
        rezult = HW1.QueueTime(new int[] { 5, 3, 4 }, 1);
        Console.WriteLine("1 test:  " + rezult);
        rezult = HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2);
        Console.WriteLine("2 test:  " + rezult);
        rezult = HW1.QueueTime(new int[] { 2, 3, 10 }, 2);
        Console.WriteLine("3 test:  " + rezult);
        Console.Read();
    }
}