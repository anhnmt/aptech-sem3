using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo collection 10 phần tử
            GenericList<string> students = new GenericList<string>(10);
            students.Add("Thinh");
            students.Add("Dung");
            students.Add("Hai");
           //hiển thị
            Console.WriteLine("Noi dung collection:");
            students.Display();
            //xóa phần tử
            students.Remove("Dung");
            //hiển thị
            Console.WriteLine("Noi dung collection sau khi xoa:");
            students.Display();
        }
    }
}
