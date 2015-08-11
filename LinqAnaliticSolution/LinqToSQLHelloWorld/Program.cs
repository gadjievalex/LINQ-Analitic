using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQLHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var cust = from c in FakeDBData.Customers where c.City == "Rio De Janeiro" select c;
            foreach(var cus in cust)
            {
                Console.WriteLine(cus.Name + " selected value ");
            }
            Console.ReadLine();
        }
    }
}
