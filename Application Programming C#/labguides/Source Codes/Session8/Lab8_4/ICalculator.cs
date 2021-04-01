using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_4
{
    //Định nghĩa giao diện Generic
    interface ICaluclator<T>
    {
        T Add(T a, T b);
        T Sub(T a, T b);
        T Div(T a, T b);
        T Mul(T a, T b);
    }
}
