using CommonClasses;
using System;
using System.Collections;
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
            OfTypeExample();
            AsEnumerableExample();

            Console.ReadLine();
        }

        private static void AsEnumerableExample()
        {
            var someCollection = EmplyeeOptionEntry.GetEmplyeeOptionsEntrys().Where(e => e.id == 1).AsEnumerable().Reverse();
            foreach(var cust in someCollection)
            {
                Console.WriteLine(cust);
            }
            PrintEnd();
        }

        private static void PrintEnd()
        {
            Console.WriteLine(" END CURENT METHOD ");
        }

        private static void OfTypeExample()
        {
            ArrayList al = Employee.GetEmplyees();
            al.Add(new Employee { Id = 22 });
            var items = al.Cast<Employee>();
            Console.WriteLine(" try cast operation using ");
            try
            {
                foreach(Employee item in items)
                {
                    Console.WriteLine(" {0} {1} {2} ", item.Id, item.firstName, item.lastName);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(" {0} {1} ", ex.Message, System.Environment.NewLine);
            }
            Console.WriteLine(" try OfType using ");
            var item2 = al.OfType<Employee>();
            foreach(Employee item in item2)
            {
                Console.WriteLine(" {0} {1} {2} ", item.Id, item.firstName, item.lastName);
            }
            PrintEnd();
        }

        private static void CastExample()
        {
            ArrayList employees = Employee.GetEmplyees();
            Console.WriteLine(" employees array type is - > " + employees.GetType());
            var seq = employees.Cast<Employee>();
            Console.WriteLine(" employees after casting type is - > " + seq.GetType());
            var emps = seq.OrderBy(e => e.lastName);
            foreach(Employee emp in emps)
            {
                Console.WriteLine(" {0} {1} ", emp.firstName, emp.lastName);
            }
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
