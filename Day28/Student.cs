using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day28
{
    public class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        public override string ToString()
        {
            return $"{FName} {LName} {Address} {ZipCode}";
        }
    }
}
