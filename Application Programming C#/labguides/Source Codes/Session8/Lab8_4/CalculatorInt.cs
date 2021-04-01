using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_4
{
    //Định nghĩa lớp thực thi giao diện từ Generic
    class CalculatorInt: ICaluclator<int>
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
