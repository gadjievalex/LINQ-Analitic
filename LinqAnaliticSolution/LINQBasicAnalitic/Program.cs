using CommonClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQBasicAnalitic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = { "0042", "010", "9", "27" };
            simpleLinqDemo(numbers);
            SortetLinqResultDemo(numbers);
            LinqClassCastingDemo();
            SortedVarAnalitic();
            Console.ReadLine();
        }

        private static void SortedVarAnalitic()
        {
            var orders = FakeDBData.Customers.Where(c => c.City == "Rio De Janeiro").SelectMany(c => c.Name);
            Console.WriteLine(orders.GetType());
        }

        private static void LinqClassCastingDemo()
        {
            ArrayList alEmployees = Employee.GetEmplyees();
            Contact[] contacts = alEmployees.Cast<Employee>().Select(e => new Contact
            {
                Id = e.Id,
                Name = string.Format("{0}{1}", e.firstName, e.lastName)
            }).ToArray<Contact>();
            Contact.PublishContacts(contacts);
            Console.WriteLine(" End casting method demo ");
        }

        private static void SortetLinqResultDemo(string[] numbers)
        {
            int[] nums = numbers.Select(s => Int32.Parse(s)).OrderBy(s=>s).ToArray();
            foreach (int num in nums)
            {
                Console.WriteLine(" Num " + num);
            }
            Console.WriteLine("Sorted LINQend method");
        }

        private static void simpleLinqDemo(string[] numbers)
        {
            int[] nums = numbers.Select(s => Int32.Parse(s)).ToArray();
            foreach (int num in nums)
            {
                Console.WriteLine(" Num " + num);
            }
            Console.WriteLine("Simple LINQend method");
        }
    }
}
