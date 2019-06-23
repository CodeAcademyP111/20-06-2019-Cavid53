using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._21._19_homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listArr={ 3, 6, 9, 2, 1};
            double result_result = ArrMethod(listArr);

            Console.WriteLine(result_result);
        }

        static double ArrMethod(int[] arr)
        {
            double result = 0;
            double result_end = 0;
            foreach (var item in arr)
            {
                result += item;
                result_end = result / arr.Length;
            }
            return result_end;

        }
    }
}
