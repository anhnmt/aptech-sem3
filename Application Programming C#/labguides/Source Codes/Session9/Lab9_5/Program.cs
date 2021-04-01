using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            
            //khai báo các biến có khả năng chứa dữ liệu null
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolval = new bool?();
            // Hiển thị giá trị
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            //sử dụng toán tử kiểm tra xem biến có null không?
            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
          //  Console.ReadLine();
            List<string> name = new List<string>();
            name.AddNotDuplicate("abc");
            name.AddNotDuplicate("abcđ");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
    static class Demo
    {
        public static bool AddNotDuplicate<T>(this List<T> item, T m)
        {
            if (item.Contains(m))
                return true;
            else
            {
                item.Add(m);
                return false;
            }

        }
    }
}
