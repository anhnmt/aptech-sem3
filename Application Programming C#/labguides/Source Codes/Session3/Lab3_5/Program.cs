using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng 
            StudentModel action = new StudentModel();
            //gọi phương thức lấy tất cả sinh viên
            Console.WriteLine("Danh sach sinh vien:");
            List<Student> listall = action.GetStudent();
            //hiển thị
            foreach (var item in listall)
            {
                item.Display();
            }
            //gọi phương thức lấy sinh viên theo id
            Console.WriteLine("Sinh vien co ma so 2:");
            Student st = action.GetStudent(2);
            //hiển thị
            st.Display();
            //gọi phương thức lấy sinh viên có tuổi từ 25-30
            Console.WriteLine("Danh sach sinh vien co tuoi tu 25-30:");
            List<Student> listage = action.GetStudent(25, 30);
            //hiển thị
            foreach (var item in listage)
            {
                item.Display();
            }
        }
    }
}
