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
            al.Add(new Employee { Id = 1, firstName = "Joe1", lastName = "Ratz" });
            al.Add(new Employee { Id = 2, firstName = "Wiliam", lastName = "Gatez" });
            al.Add(new Employee { Id = 3, firstName = "Anders", lastName = "Hejsberg" });
            al.Add(new Employee { Id = 4, firstName = "David", lastName = "Lightman" });
            al.Add(new Employee { Id = 5, firstName = "Kevin", lastName = "Flyin" });
            return al;
        }
        public static Employee[] GetEmployeesArrayList()
        {
            Employee[] al = new Employee[]
            {
                new Employee { Id = 1, firstName = "Joe1", lastName = "Ratz" },
                new Employee { Id = 2, firstName = "Wiliam", lastName = "Gatez" },
                new Employee { Id = 3, firstName = "Anders", lastName = "Hejsberg" },
                new Employee { Id = 4, firstName = "David", lastName = "Lightman" },
                new Employee { Id = 5, firstName = "Kevin", lastName = "Flyin" }
            };
            
            return al;
        }
    }
}
