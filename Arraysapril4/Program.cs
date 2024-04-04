using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraysapril4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            /* int[] num = new int[n];
             for(int i=0;i<num.Length; i++)
             {
                 num[i]=int.Parse(Console.ReadLine());
             }
             /*  for(int i=0;i<num.Length ; i++) { Console.WriteLine(num[i]); }
               int sum = 0;
               int count=0;
               float avg = 0;
               for(int i = 0; i < num.Length; i++)
               {
                   count++;
                   sum = sum + num[i];

               }
               avg = sum / count;
               Console.WriteLine(sum);
               Console.WriteLine(avg);*/
            /* Console.WriteLine("Enter your key value to compare");
             int key=Convert.ToInt32(Console.ReadLine());
             bool val = false;
             int index = 0;
             for(int i=0;i<num.Length ;i++)
             {
                 if (num[i]==key)
                 {
                     val = true;
                     index = i;
                     break;
                 }

             }

             if (val == true)
             {
                 Console.WriteLine("Value found at "+index);

             }
             else { Console.WriteLine("Not found"); }
         }*/

            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=n-i; j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=i; k++) {
                    Console.Write("*");
                }
              
           
                for(int j=1; j <= i-1; j++)
                {
                    Console.Write("*");
                }
             
                Console.WriteLine();
            }
            for (int i =n-1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }


                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
    }
}
