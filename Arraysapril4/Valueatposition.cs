using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arraysapril4
{
    public class Valueatposition
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
            for(int i=0; i < num.Length; i++)
            {
                for(int j=i+1;j<num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        num[i] = num[i] + num[j] - (num[j] = num[i]);
                    }
                }
            }
            for(int i=0;i<num.Length ; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("Enter the required ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{key} max value" + num[num.Length-key]);
        }
    }
}

