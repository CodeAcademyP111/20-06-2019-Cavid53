using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._22._19_homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please etner the sentence.");
            string wordContain = Console.ReadLine();
            #region this is first method
            // string res = string.Join(" ", wordContain.Split(' ').Select(s => new String(s.Reverse().ToArray())));
            //Console.WriteLine(res);
            #endregion




            Reverse(wordContain);
            Console.WriteLine();



        }

        static string Reverse(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {

                Console.Write(word[i]);
            }
            return result;

        }










    }
}
