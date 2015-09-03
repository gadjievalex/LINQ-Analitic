using CommonClasses;
using CommonClasses.CustomComparer;
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
            SelectManyAdvanced();
            SelectManySecondType(presidents);

            TakeAnalitic(presidents);
            AdvancTakeExample(presidents);

            TakeWhileExample(presidents);
            TakeWhileIndexExample(presidents);

            SkipExample(presidents);
            SkipIndexExample(presidents);

            ConcateExample(presidents);
            AlternativeSelectManyConcatExample(presidents);

            OrderByExample(presidents);
            OrderByCustomComparerExample(presidents);

            OrderByDescendingExample(presidents);
            OrderByDescendingExampleCustomComparer(presidents);

            ThenBy(presidents);
            ThenByWithComparerExample(presidents);

            TheByDescendingExample(presidents);
            ThenByDescendingComparatorExample(presidents);

            ReverseExample(presidents);

            JoinExample();

            Console.ReadLine();
        }

        private static void JoinExample()
        {
            Employee[] emplyees = Employee.GetEmployeesArrayList();
            EmplyeeOptionEntry[] empOptions = EmplyeeOptionEntry.GetEmplyeeOptionsEntrys();
            var eplyeeOptions = emplyees.Join(empOptions, e => e.Id, o => o.id, (e, o) => new { id = e.Id, name = string.Format(" {0} {1} ", e.firstName, e.lastName), option = o.optionsCount });
            foreach (var item in eplyeeOptions)
            {
                Console.WriteLine(item);
            }
        }

        private static void ReverseExample(string[] presidents)
        {
            IEnumerable<string> item = presidents.Reverse();
            PrintResult(item, "ReverseExample", ConsoleColor.DarkBlue);
        }

        private static void ThenByDescendingComparatorExample(string[] presidents)
        {
            VowelToConsonantComparer comparer = new VowelToConsonantComparer();
            IEnumerable<string> items = presidents.OrderBy(n => n.Length).ThenByDescending((s => s), comparer);
            PrintResult(items, "ThenByDescendingComparatorExample", ConsoleColor.DarkYellow);
        }

        private static void TheByDescendingExample(string[] presidents)
        {
            IEnumerable<string> items = presidents.OrderBy(s => s.Length).ThenByDescending(s => s);
            PrintResult(items, "TheByDescendingExample", ConsoleColor.Magenta);
        }

        private static void ThenByWithComparerExample(string[] presidents)
        {
            VowelToConsonantComparer comparer = new VowelToConsonantComparer();
            IEnumerable<string> items = presidents.OrderBy(n => n.Length).ThenBy((s => s), comparer);
            PrintResult(items, "ThenByWithComparerExample", ConsoleColor.Yellow);
        }

        private static void ThenBy(string[] presidents)
        {
            IEnumerable<string> items = presidents.OrderBy(s => s.Length).ThenBy(s => s);
            PrintResult(items, "ThenBy", ConsoleColor.Red);
        }

        private static void OrderByDescendingExampleCustomComparer(string[] presidents)
        {
            VowelToConsonantComparer comparer = new VowelToConsonantComparer();
            IEnumerable<string> items = presidents.OrderByDescending((s => s), comparer);
            PrintResult(items, "OrderByDescendingExampleCustomComparer");
        }

        private static void OrderByDescendingExample(string[] presidents)
        {
            IEnumerable<string> items = presidents.OrderByDescending(s => s);
            PrintResult(items);
        }

        private static void OrderByCustomComparerExample(string[] presidents)
        {
            VowelToConsonantComparer myComp = new VowelToConsonantComparer();
            IEnumerable<string> items = presidents.OrderBy((s => s), myComp);
            foreach (string item in items)
            {
                Console.WriteLine("OrderByCustomComparerExample");
                int vCount = 0;
                int cCount = 0;
                myComp.GetVowelConsonantCount(item, ref vCount, ref cCount);
                double dRatio = (double)vCount / (double)cCount;
                Console.WriteLine(item + " - " + dRatio + " - " + vCount + " : " + cCount);
            }
        }

        private static void OrderByExample(string[] presidents)
        {
            IEnumerable<string> items = presidents.OrderBy(s => s.Length);
            PrintResult(items);
        }

        private static void AlternativeSelectManyConcatExample(string[] presidents)
        {
            IEnumerable<string> items = new[] { presidents.Take(5), presidents.Skip(5) }.SelectMany(s => s);
            PrintResult(items);
        }

        private static void ConcateExample(string[] presidents)
        {
            IEnumerable<string> items = presidents.Take(5).Concat(presidents.Skip(5));
            PrintResult(items);
        }

        private static void SkipIndexExample(string[] presidents)
        {
            IEnumerable<string> items = presidents.SkipWhile((s, i) => s.Length > 4 && i < 10);
            PrintResult(items);
        }

        private static void SkipExample(string[] presidents)
        {
            IEnumerable<string> items = presidents.Skip(1);
            PrintResult(items);
        }

        private static void TakeWhileIndexExample(string[] presidents)
        {
            IEnumerable<string> items = presidents.TakeWhile((s, i) => s.Length < 10 && i < 5);
            PrintResult(items);
        }

        private static void TakeWhileExample(string[] presidents)
        {
            IEnumerable<string> items = presidents.TakeWhile(s => s.Length < 10);
            PrintResult(items);
        }

        private static void AdvancTakeExample(string[] presidents)
        {
            IEnumerable<char> items = presidents.Take(5).SelectMany(s => s.ToArray());
            Console.WriteLine("##############################");
            foreach (char ch in items)
            {
                Console.WriteLine(ch + " char from select many ");
            }
            Console.WriteLine("##############################");
        }

        private static void TakeAnalitic(string[] presidents)
        {
            IEnumerable<string> items = presidents.Take(5);
            PrintResult(items);
        }

        private static void SelectManySecondType(string[] presidents)
        {
            IEnumerable<char> chars = presidents.SelectMany((p, i) => i < 5 ? p.ToArray() : new char[] { });
            Console.WriteLine("##############################");
            foreach(char ch in chars)
            {
                Console.WriteLine(ch + " char from select many ");
            }
            Console.WriteLine("##############################");
        }

        private static void SelectManyAdvanced()
        {
            Console.WriteLine("Practic selectMany analitic");
            Employee[] emplyees = Employee.GetEmployeesArrayList();
            EmplyeeOptionEntry[] empOptions = EmplyeeOptionEntry.GetEmplyeeOptionsEntrys();
            var employeeOptions = emplyees.SelectMany(e => empOptions.Where(eo => eo.id == e.Id).Select(eo => new { id = eo.id, optionsCount = eo.optionsCount }));
            Console.WriteLine("##############################");
            foreach(var item in employeeOptions)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" from result array AdvancSelectMany ");
            Console.WriteLine("##############################");
        }

        private static void SelectManyAnalitic(string[] presidents)
        {
            IEnumerable<char> chars = presidents.SelectMany(p => p.ToArray());
            foreach(char c in chars)
            {
                Console.WriteLine(c + " char ");
            }
            
        }

        private static void SelectIndexAnalitic(string[] presidents)
        {
            var result = presidents.Select((p, i) => new { indexe = i, LastName = p }.ToString());
            PrintResult(result, "SelectIndexAnalitic", ConsoleColor.Green);
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

        private static void PrintResult(IEnumerable<string> sequence, string method = "", ConsoleColor consoleColor = ConsoleColor.White)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("##############################");
            if (method != "") { Console.WriteLine(" @@@@@@@@@@@@ " + method + " @@@@@@@@@@@ "); }
            foreach(string s in sequence)
            {
                Console.WriteLine("{0}", s);
            }
            Console.WriteLine("##############################");
            Console.ResetColor();
        }
    }
}
