using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng Department
            Department dep = new Department();
            //sử dung foreach truy xuất tập hợp
            foreach (string item in dep)
            {
                Console.WriteLine(item);
            }
            //tạo đối tượng Flower
            Flower f = new Flower();
            //dùng foreach duyệt qua tập hợp
            foreach (string item in f.GetFlower())
            {
                Console.WriteLine(item);
            }
        }
    }
}
