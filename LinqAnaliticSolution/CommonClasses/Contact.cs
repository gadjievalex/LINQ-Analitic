using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Contact
    {
        public int Id;
        public string Name;
        public static void PublishContacts(Contact[]contacts)
        {
            foreach(Contact c in contacts)
            {
                Console.WriteLine("Contact id {0} contact {1}", c.Id, c.Name);
            }
        }
    }
}
