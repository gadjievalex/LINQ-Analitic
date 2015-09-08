using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsAnalitic
{
    class Program
    {
        static void Main(string[] args)
        {
            DistinctExample();
            UnionExample();
            IntersectionExample();
            ExceptExample();
            CastExample();

            Console.ReadLine();
        }

        private static void CastExample()
        {
            
        }

        private static void ExceptExample()
        {
            string[] presidents = PresidentsArray.names;
            IEnumerable<string> processed = presidents.Take(4);
            IEnumerable<string> exeptions = presidents.Except(processed);
            foreach(string name in exeptions)
            {
                Console.WriteLine(name + " name ");
            }
        }

        private static void IntersectionExample()
        {
            string[] presidents = PresidentsArray.names;
            IEnumerable<string> first = presidents.Take(5);
            IEnumerable<string> second = presidents.Skip(4);
            IEnumerable<string> interSect = first.Intersect(second);
            Console.WriteLine(" presidents count " + presidents.Count());
            Console.WriteLine(" first cOunt " + first.Count());
            Console.WriteLine(" second count " + second.Count());
            Console.WriteLine(" interSect count " + interSect.Count());
            foreach(string name in interSect)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(" END InterSect #### ");
        }

        private static void UnionExample()
        {
            string[] presidents = PresidentsArray.names;
            IEnumerable<string> first = presidents.Take(5);
            IEnumerable<string> second = presidents.Skip(4);
            IEnumerable<string> concat = first.Concat<string>(second);
            IEnumerable<string> union = first.Union<string>(second);
            Console.WriteLine(" presidents count " + presidents.Count());
            Console.WriteLine(" first cOunt " + first.Count());
            Console.WriteLine(" second count " + second.Count());
            Console.WriteLine(" concat count " + concat.Count());
            Console.WriteLine(" union count " + union.Count());
            Console.WriteLine(" END UNION #### ");
        }

        private static void DistinctExample()
        {
            //removed existings elements
            string[] presidents = PresidentsArray.names;
            Console.WriteLine(" presidents " + presidents.Count());
            IEnumerable<string> presidentsWithSDupes = presidents.Concat(presidents);
            Console.WriteLine(" Presidents count = " + presidentsWithSDupes.Count());
            IEnumerable<string> presidentsDiscinct = presidentsWithSDupes.Distinct();
            Console.WriteLine("presidents count " + presidentsDiscinct.Count());
        }
    }
}
