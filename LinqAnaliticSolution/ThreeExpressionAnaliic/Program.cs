using CommonClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeExpressionAnaliic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] { 1, 2, 3, 4, 5, 6 };
            FuncAnalitic(ints);

            Console.ReadLine();
        }

        private static void FuncAnalitic(int[] ints)
        {
            Func<int, bool> GreaterThanTwo = i => i > 2;
            IEnumerable<int> intsGreatThanTwo = ints.Where(GreaterThanTwo);
            PrintResult(intsGreatThanTwo);
        }

        private static void PrintResult(IEnumerable<int> intsGreatThanTwo)
        {
           foreach(int i in intsGreatThanTwo)
           {
               Console.WriteLine(i.ToString());
           }
        }
    }
}
