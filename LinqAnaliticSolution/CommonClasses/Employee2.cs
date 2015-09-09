using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Employee2
    {
        public string Id;
        public string firstName;
        public string lastName;
        public static ArrayList GetEmplyees()
        {
            ArrayList al = new ArrayList();
            al.Add(new Employee2 { Id = "1", firstName = "Joe1", lastName = "Ratz" });
            al.Add(new Employee2 { Id = "2", firstName = "Wiliam", lastName = "Gatez" });
            al.Add(new Employee2 { Id = "3", firstName = "Anders", lastName = "Hejsberg" });
            al.Add(new Employee2 { Id = "4", firstName = "David", lastName = "Lightman" });
            al.Add(new Employee2 { Id = "5", firstName = "Kevin", lastName = "Flyin" });
            return al;
        }
        public static Employee2[] GetEmployeesArrayList()
        {
            Employee2[] al = new Employee2[]
            {
                new Employee2 { Id = "1", firstName = "Joe1", lastName = "Ratz" },
                new Employee2 { Id = "2", firstName = "Wiliam", lastName = "Gatez" },
                new Employee2 { Id = "3", firstName = "Anders", lastName = "Hejsberg" },
                new Employee2 { Id = "4", firstName = "David", lastName = "Lightman" },
                new Employee2 { Id = "5", firstName = "Kevin", lastName = "Flyin" }
            };

            return al;
        }
    }
}
