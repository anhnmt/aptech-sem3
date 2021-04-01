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
        //constructor khởi tạo
        public Employee()
        {
            this.Name = "Tran Hai Ha";
            this.Address = "Ha Noi";
            this.Id = 111;
            this.Age = 22;
        }
        //triển khai phương thức thành phần
        partial void Display()
        {
            Console.WriteLine("Ma so:" + Id);
            Console.WriteLine("Ho va ten:" + Name);
            Console.WriteLine("Dia chi:" + Address);
            Console.WriteLine("Tuoi:" + Age);
        }
        //định nghĩa phương thức gọi phương thức thành phần
        public void CallDisplay()
        {
            Display();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng Employee
            Employee emp = new Employee();
            //gọi phương thức thành phần
            emp.CallDisplay();
        }
    }
}
