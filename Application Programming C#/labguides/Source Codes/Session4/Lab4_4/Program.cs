using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tạo một nhân viên
            IPerson staff = new Staff();
            object data = "Bach Khoa Aptech";
            //gọi các hành động
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);
            //tạo sinh viên
            IPerson student = new Student() { Id = "S10", Name = "CHUNGLD", Age = 20 };
            //hiển thị dữ liệu
            student.Display(student);
        }
    }
}
