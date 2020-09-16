using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_3
{
    public abstract class Student
    {
        public string id, fullname, dob;
        public bool gender;
        public abstract void print();
        public abstract void accept();
    }
}
