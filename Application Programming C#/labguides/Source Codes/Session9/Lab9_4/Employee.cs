using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_4
{
    //Định nghĩa lớp thành phần Employee 
    partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        //định nghĩa phươn thức thành phần Display
        partial void Display();
    }
}
