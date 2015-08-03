using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_HelloWorld_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] greetings = { " hello world ", "Hello linq", "hello git" };
            var items = from s in greetings where s.EndsWith("linq") select s;
            foreach (var item in items)
            {
                Console.WriteLine(" item " + item);
            }
            Console.ReadLine();
        }
    }
}
