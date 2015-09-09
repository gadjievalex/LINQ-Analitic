using CommonClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementAnalitic
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultIfEmptyExample();
            WithOutDefaultOrEmpty();
            WithDefaultIfEmptyExample();

            Console.ReadLine();
        }

        private static void WithDefaultIfEmptyExample()
        {
            ArrayList employeeAL = Employee.GetEmplyees();
            employeeAL.Add(new Employee { Id = 102, firstName = "Michael", lastName = "Bolton" });
            Employee[] employees = employeeAL.Cast<Employee>().ToArray();
            EmplyeeOptionEntry[] empOptions = EmplyeeOptionEntry.GetEmplyeeOptionsEntrys();
            var emplyeeOptions = employees.GroupJoin(empOptions, e => e.Id, o => o.id, (e, os) => os.DefaultIfEmpty().Select(o => new { id = e.Id, name = e.firstName, options = o != null ? o.optionsCount : 0 })).SelectMany(r => r);
            foreach (var item in emplyeeOptions)
            {
                Console.WriteLine(item);
            }
            PrintEnd();
        }

        private static void WithOutDefaultOrEmpty()
        {
            ArrayList employeeAL = Employee.GetEmplyees();
            employeeAL.Add(new Employee { Id = 102, firstName = "Michael", lastName = "Bolton" });
            Employee[] employees = employeeAL.Cast<Employee>().ToArray();
            EmplyeeOptionEntry[] empOptions = EmplyeeOptionEntry.GetEmplyeeOptionsEntrys();
            var employeeOptions = employees.GroupJoin(empOptions, e => e.Id, o => o.id, (e, os) => os.Select(o => new { Id = e.Id, name = e.firstName, options = o != null ? o.optionsCount : 0 })).SelectMany(r => r);
            foreach(var item in employeeOptions)
            {
                Console.WriteLine(item);
            }
            PrintEnd();
        }

        private static void DefaultIfEmptyExample()
        {
            string[] presidents = PresidentsArray.names;
            string jones = presidents.Where(n => n.Equals("Jones")).DefaultIfEmpty("Not Found JONES").First();
            Console.WriteLine(jones);

            PrintEnd();
        }
        private static void PrintEnd()
        {
            Console.WriteLine(" STOP METHOD ");
        }
    }
}
