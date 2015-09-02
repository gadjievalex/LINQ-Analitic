using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionAnalitic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] presidents = PresidentsArray.names;

            WhereAnalitic(presidents);
            WhereWithIndexAnalitic(presidents);

            SelectAnalitic(presidents);
            SelectIndexAnalitic(presidents);

            SelectManyAnalitic(presidents);
            Console.ReadLine();
        }

        private static void SelectManyAnalitic(string[] presidents)
        {
            IEnumerable<char> chars = presidents.SelectMany(p => p.ToArray());
            foreach(char c in chars)
            {
                Console.WriteLine(c + " char ");
            }
            Console.WriteLine("Practic selectMany analitic");
            Employee[] emplyees = Employee.GetEmployeesArrayList();
            EmplyeeOptionEntry[] empOptions = EmplyeeOptionEntry.GetEmplyeeOptionsEntrys();
            var employeeOptions = emplyees.SelectMany(e => empOptions.Where(eo => eo.id == e.Id));
        }

        private static void SelectIndexAnalitic(string[] presidents)
        {
            var result = presidents.Select((p, i) => new { indexe = i, LastName = p }.ToString());
            PrintResult(result);
        }

        private static void SelectAnalitic(string[] presidents)
        {
            var sequence = presidents.Select(p => new { LastName = p, Length = p.Length }.ToString());
            PrintResult(sequence);
        }

        private static void WhereWithIndexAnalitic(string[] presidents)
        {
            IEnumerable<string> sequence = presidents.Where((p, i) => (i & 1) == 1);
            PrintResult(sequence);
        }

        private static void WhereAnalitic(string[] presidents)
        {
            IEnumerable<string>sequence=presidents.Where(p=>p.StartsWith("A"));
            PrintResult(sequence);
        }

        private static void PrintResult(IEnumerable<string> sequence)
        {
            Console.WriteLine("##############################");
            foreach(string s in sequence)
            {
                Console.WriteLine("{0}", s);
            }
            Console.WriteLine("##############################");
        }
    }
}
