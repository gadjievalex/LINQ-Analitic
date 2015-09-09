using CommonClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationAnalitic
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeExample();
            RepeatExample();
            EmptyExampe();

            Console.ReadLine();
        }

        private static void EmptyExampe()
        {
            IEnumerable<string> strings = Enumerable.Empty<string>();
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(strings.Count() + " count of strings ");
            PrintEnd();
        }

        private static void RepeatExample()
        {
            IEnumerable<Employee> employees = Enumerable.Repeat(new Employee { Id = 1, firstName = "F", lastName = "L" }, 10);
            foreach(Employee item in employees)
            {
                Console.WriteLine(item.ToString());
            }
            PrintEnd();
        }

        private static void RangeExample()
        {
            IEnumerable<int> ints = Enumerable.Range(1, 10);
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
            PrintEnd();            
        }

        private static void PrintEnd()
        {
            Console.WriteLine(" END METHOD ");
        }
    }
}
