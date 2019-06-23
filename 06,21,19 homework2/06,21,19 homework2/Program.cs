using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_21_19_homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            string EndWord = "Cavide esq olsuns";
           Console.WriteLine(newArr(EndWord));
        }

        static int newArr(string word)
        {
            int count = 0;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    if(word[i]==' ')
            //    {

            //       count++;
            //    }
            //}
            foreach (var item in word)
            {

                if(item==' ')
                 {

                      count++;
                 }
            }
            return count;

        }
    }
}
