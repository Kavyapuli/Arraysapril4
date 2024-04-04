using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraysapril4
{
    public class MaxMin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int max= int.MaxValue; int min = int.MinValue;
            int min1=int.MinValue; int min2=int .MinValue; 
            for(int i=0;i< num.Length; i++)
            {
                if (num[i] > min)
                {
                    min2 = min1;
                    min1 = min;

                    min = num[i];
                }
                else if (num[i]>min1 && num[i]<min)
                {
                    min2 = min1;
                    min1 = num[i];
                }
                else if (num[i]>min2 && num[i]<min && num[i]<min1)
                {
                    min2 = num[i];
                }
            }
            Console.WriteLine("Second max value "+min2);
          /*  Console.WriteLine("Max value "+min);
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] < max) { max = num[i]; } 
            }
            Console.WriteLine("Min value "+max);*/
        }
    }
}
