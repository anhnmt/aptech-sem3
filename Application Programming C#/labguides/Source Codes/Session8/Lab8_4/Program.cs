using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tạo đối tượng calculator
            CalculatorInt cal = new CalculatorInt();
            int a=10,b=5;
            //Test kết quả
            Console.WriteLine("{0}+{1}={2}", a, b, cal.Add(a, b));
            Console.WriteLine("{0}-{1}={2}", a, b, cal.Sub(a, b));
            Console.WriteLine("{0}*{1}={2}", a, b, cal.Mul(a, b));
            Console.WriteLine("{0}/{1}={2}", a, b, cal.Div(a, b));

        }
    }
}
