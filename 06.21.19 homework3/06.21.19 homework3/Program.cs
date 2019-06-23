using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._21._19_homework3
{
    class Program
    {

        static void Main(string[] args)
        {
            string newName = "Kamran";
            

            VoidMethod(newName);
           


        }
        static void VoidMethod(string name)
        {
            int count = 0;
            foreach (var item in name)
            {
                foreach (var word in name)
                {
                    if (item == word)
                    {
                        count++;
                    }
                }
                Console.WriteLine(item + " " + count+ "defe tekrarlanib");
                count = 0;
            }
           





        }
    }
}
