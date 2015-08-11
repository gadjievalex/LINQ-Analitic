using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingLinqAnalitic
{
    class Program
    {
        private static ArrayList arrayList = new ArrayList();

        static void Main(string[] args)
        {
            ConfigureList();
            CastAnalitic();
            OffTypeAnalitic();
            Console.ReadLine();
        }

        private static void OffTypeAnalitic()
        {
            IEnumerable<string> names = arrayList.OfType<string>().Where(n => n.Length < 7);
            PrintData(names);
        }

        private static void CastAnalitic()
        {
            IEnumerable<string> names = arrayList.Cast<string>().Where(n => n.Length < 7);
            PrintData(names);
        }

        private static void PrintData(IEnumerable<string> names)
        {
            foreach(string name in names)
            {
                Console.WriteLine(name + " value ");
            }
        }

        private static void ConfigureList()
        {
            arrayList.Add("Adams");
            arrayList.Add("Arthur");
            arrayList.Add("Buchanan");
        }
    }
}
