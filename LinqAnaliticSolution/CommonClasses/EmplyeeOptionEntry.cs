using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class EmplyeeOptionEntry
    {
        public int id;
        public long optionsCount;
        public DateTime dateAwarded;
        public static EmplyeeOptionEntry[]GetEmplyeeOptionsEntrys()
        {
            EmplyeeOptionEntry[] empOptions = new EmplyeeOptionEntry[]
            {
                new EmplyeeOptionEntry
                {
                    id=1,
                    optionsCount=2,
                    dateAwarded = DateTime.Now
                },
                new EmplyeeOptionEntry
                {
                    id=2,
                    optionsCount=2000,
                    dateAwarded = DateTime.Now
                },
                new EmplyeeOptionEntry
                {
                    id=3,
                    optionsCount=10000,
                    dateAwarded = DateTime.Now
                },
                new EmplyeeOptionEntry
                {
                    id=4,
                    optionsCount=500,
                    dateAwarded = DateTime.Now
                },
                new EmplyeeOptionEntry
                {
                    id=5,
                    optionsCount=1000,
                    dateAwarded = DateTime.Now
                },
                new EmplyeeOptionEntry
                {
                    id=3,
                    optionsCount=7000,
                    dateAwarded = DateTime.Now
                },
                new EmplyeeOptionEntry
                {
                    id=4,
                    optionsCount=8000,
                    dateAwarded = DateTime.Now
                },
                new EmplyeeOptionEntry
                {
                    id=4,
                    optionsCount=1500,
                    dateAwarded = DateTime.Now
                },
            };
            return empOptions;
        }
    }
}
