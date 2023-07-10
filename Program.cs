using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timgiatrimin_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.Write("mời nhập vào số lượng phần tử n :");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("moi nhap vao gia tri phan tu thu {0} = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int min = numbers[0]; 
            int max = numbers[0];
            for (int i = 1; i < n; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("gia tri lon nhat la " +max);
            Console.WriteLine("gia tri nho nhat la " +min);
        }
    }
}
