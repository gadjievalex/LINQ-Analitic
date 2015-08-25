using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAnalitic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 9, 10 };

            TestApplicationOddMethod(nums);
            AnonimMethodAnalitic(nums);
            LambdaMethodAnalitic(nums);
            Console.ReadLine();
        }

        private static void LambdaMethodAnalitic(int[] nums)
        {
            int[] oddNums = Common.FilterArrayOfInts(nums, i => ((i & 1) == 1));
            AnalizeArray(oddNums);
        }

        private static void AnonimMethodAnalitic(int[] nums)
        {
            int[] oddNums = Common.FilterArrayOfInts(nums, delegate(int i) { return ((i & 1) == 1); });
            AnalizeArray(oddNums);
        }

        private static void AnalizeArray(int[] oddNums)
        {
            foreach (int i in oddNums)
            {
                Console.WriteLine(" i " + i);
            }
        }

        private static void TestApplicationOddMethod(int[] nums)
        {
            int[] oddNum = Common.FilterArrayOfInts(nums, Application.IsOdd);
            AnalizeArray(oddNum);
        }
    }
}
