using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_5
{
    class Department : IEnumerable
    {
        //khai báo mảng dữ liệu
        string[] names = { "Finance", "Human Resource", "Information Technology", "Marketing" };
        //thực thi phương thức GetEnumberator của giao diện IEnumberable
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }
}
