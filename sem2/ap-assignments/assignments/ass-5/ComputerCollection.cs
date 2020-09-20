using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_5
{
    class ComputerCollection
    {
        SortedList<string,Computer> cList;
        public ComputerCollection()
        {
            cList = new SortedList<string, Computer>();
        }

        public void add()
        {
            Computer c = new Computer();
            Console.Write("Enter student id: ");
            c.pID = Console.ReadLine().Trim();
        }
    }
}
