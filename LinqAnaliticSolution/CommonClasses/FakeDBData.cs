using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class FakeDBData
    {
        public static Customer[] Customers = 
        {
            new Customer{City = "Rio De Janeiro", Name = "Sam"},
            new Customer{City="Minsk", Name="Kave"}
        };
    }
}
