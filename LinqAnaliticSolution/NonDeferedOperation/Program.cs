using CommonClasses;
using CommonClasses.CustomComparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonDeferedOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            ToArrayExample();
            ToListExample();
            ToDictionaryExample();
            ToDictionaryExampleWithComparer();
            ToDictionaryAnonimousClassGeneration();
            ToDictionaryAnonimousAndComparerExample();
            ToLookUpExample();
            ToLookUpComparerExample();
            ToLookUpThreeTypeExample();
            ToLookUpFourExample();

            Console.ReadLine();
        }

        private static void ToLookUpFourExample()
        {
            ILookup<string, string> lookup = Actor2.GetActors().ToLookup(k => k.birthYear, a => string.Format(" {0} {1} ", a.firstName, a.lastName), new StringifieldNumberComparer());
            IEnumerable<string> actors = lookup["1964"];
            foreach(var actor in actors)
            {
                Console.WriteLine(" {0} ", actor);
            }
            PrindMethodEnd();
        }

        private static void ToLookUpThreeTypeExample()
        {
            ILookup<int, string> lookup = Actor.GetActors().ToLookup(k => k.birthYear, a => string.Format(" {0} {1} ", a.firstName, a.lastName));
            IEnumerable<string> actors = lookup[1964];
            foreach (var actor in actors)
            {
                Console.WriteLine(" {0} "actor);
            }
            PrindMethodEnd();
        }

        private static void ToLookUpComparerExample()
        {
            ILookup<string, Actor2> lookup = Actor2.GetActors().ToLookup(k => k.birthYear, new StringifieldNumberComparer());
            IEnumerable<Actor2> actors = lookup["1964"];
            foreach (var actor in actors)
            {
                Console.WriteLine(" {0} {1} ", actor.firstName, actor.lastName);
            }
            PrindMethodEnd();
        }

        private static void ToLookUpExample()
        {
            ILookup<int, Actor> lookup = Actor.GetActors().ToLookup(k => k.birthYear);
            IEnumerable<Actor> actors = lookup[1964];
            foreach (var actor in actors)
            {
                Console.WriteLine(" {0} {1} ", actor.firstName, actor.lastName);
            }
            PrindMethodEnd();
        }

        private static void ToDictionaryAnonimousAndComparerExample()
        {
            Dictionary<string, string> eDictionary = Employee2.GetEmployeesArrayList().ToDictionary(k => k.Id, i => string.Format("{0} {1}", i.firstName, i.lastName), new StringifieldNumberComparer());
            string name = eDictionary["2"];
            Console.WriteLine(" employee id==2 {0} ", name);
            name = eDictionary["00002"];
            Console.WriteLine(" employee with id=00002 {0} ", name);
            PrindMethodEnd();
        }

        private static void ToDictionaryAnonimousClassGeneration()
        {
            Dictionary<int, string> eDictionary = Employee.GetEmployeesArrayList().ToDictionary(k => k.Id, i => string.Format("{0} {1}", i.firstName, i.lastName));
            string name = eDictionary[2];
            Console.WriteLine(" employee with id=2 {0} ", name);
            PrindMethodEnd();
        }

        private static void ToDictionaryExampleWithComparer()
        {
            Dictionary<string, Employee2> eDictionary = Employee2.GetEmployeesArrayList().ToDictionary(k => k.Id, new StringifieldNumberComparer());
            Employee2 e = eDictionary["2"];
            Console.WriteLine(" employee id==2 {0} {1} ", e.firstName, e.lastName);
            e = eDictionary["00002"];
            Console.WriteLine(" employee with id=00002 {0} {1} ", e.firstName, e.lastName);
            PrindMethodEnd();
        }

        private static void ToDictionaryExample()
        {
            Dictionary<int, Employee> eDictionary = Employee.GetEmployeesArrayList().ToDictionary(k => k.Id);
            Employee e = eDictionary[2];
            Console.WriteLine(" employee with id == 2 {0} {1} ", e.firstName, e.lastName);
            PrindMethodEnd();
        }

        private static void ToListExample()
        {
            string[] presidents = PresidentsArray.names;
            List<string> names = presidents.ToList();
            foreach (string name in names)
            {
                Console.WriteLine(name+" like List ");
            }
            PrindMethodEnd();
        }

        private static void ToArrayExample()
        {
            string[] presidents = PresidentsArray.names;
            string[] names = presidents.OfType<string>().ToArray();
            foreach(string name in names)
            {
                Console.WriteLine(name+" like Array ");
            }
            PrindMethodEnd();
        }

        private static void PrindMethodEnd()
        {
            Console.WriteLine("-------------------------");
        }
    }
}
