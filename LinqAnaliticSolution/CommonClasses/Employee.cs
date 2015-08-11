using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Employee
    {
        public int Id;
        public string firstName;
        public string lastName;
        public static ArrayList GetEmplyees()
        {
            ArrayList al = new ArrayList();
            al.Add(new Employee { Id = 1, firstName = "Joe1", lastName = "Ratzz11" });
            al.Add(new Employee { Id = 1, firstName = "Joe2", lastName = "Ratzz22" });
            al.Add(new Employee { Id = 1, firstName = "Joe3", lastName = "Ratzz33" });
            return al;
        }
    }
}
