using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng contact với constructor không tham số
            Contact ct1 = new Contact();
            //gán giá trị cho ct1
            ct1.Id = 6;
            ct1.FirstName = "Nguyen Thi";
            ct1.LastName = "Hoa";
            ct1.Address = "Ha Noi";
            ct1.Phone = "0978735922";
            ct1.Email = "hoahoa@gmail.com";
            //tạo đối tượng contact với constructor có tham số
            Contact ct2 = new Contact(5, "Tran Thi", "Tinh", "Tuyen Quang",
                "0987874555", "bupbecotinhyeu@yahoo.com");
            //hiển thị thông tin ct1 và ct2
            ct1.Display();
            ct2.Display();
        }
    }
}
