﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai báo và khởi tạo danh sách sinh viên sử dụng List generic
            List<Student> list = new List<Student>()
            {
                new Student{Id="S10",FirstName="Nguyen Thu",LastName="Phuong",Avg=9.5},
                new Student{Id="S12",FirstName="Tran Thi",LastName="Thuy",Avg=9.0},
                new Student{Id="S13",FirstName="Le Hoang",LastName="Nhat",Avg=8.0},
                new Student{Id="S14",FirstName="Nguyen Van",LastName="Phong",Avg=6.5},
                new Student{Id="S15",FirstName="Hoang Thi",LastName="Hue",Avg=9.7},
                new Student{Id="S16",FirstName="Nguyen Tien",LastName="Tung",Avg=5.0},
                new Student{Id="S17",FirstName="Nguyen Thien",LastName="Nhan",Avg=4.8}
            };
            //in danh sách sinh viên
            Console.WriteLine("Danh sach sinh vien:");
            foreach (var st in list)
            {
                Console.Write(st);
            }
            //tìm sinh viên có điểm trung bình cao nhất
            double max = list[0].Avg;
            Student stmax = list[0];
            foreach (var st in list)
            {
                if (st.Avg > max)
                {
                    max = st.Avg;
                    stmax = st;
                }
            }
            //in kết quả
            Console.WriteLine("\nSinh vien co diem cao nhat la:");
            Console.Write(stmax);
            //sắp xếp danh sách sinh viên tăng dần theo điểm trung bình
            list.Sort();
            Console.WriteLine("\nDanh sach sinh vien diem trung binh tang dan:");
            foreach (var st in list)
            {
                Console.Write(st);
            }
        }
    }
}
