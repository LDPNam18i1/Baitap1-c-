﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    class Program_1_
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so sinh vien");
            n = Int32.Parse(Console.ReadLine());
            // tao mang doi tuong Sv
            SV_1_[] sinhvien = new SV_1_[n];
            for (int i = 0; i < n; i++)
            {
                sinhvien[i] = new SV_1_();
                sinhvien[i].nhapthongtin();
                sinhvien[i].tinhTb();
                sinhvien[i].In();
            }
            // tim ra sinh vien nao co diem tung binh thap nhap
            float min = sinhvien[0].tinhTb();
            for (int i = 1; i < n; i++)
            {
                if (sinhvien[i].tinhTb() < min)
                    min = sinhvien[i].tinhTb();
            }
            Console.WriteLine("SV co diem thap nhat la {0}", min);
            // sap xep mang sv theo diem tb tang dan

            SV_1_ tmp;
            {
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                        if (sinhvien[i].tinhTb() < sinhvien[j].tinhTb())
                        {
                            tmp = sinhvien[i];
                            sinhvien[i] = sinhvien[j];
                            sinhvien[j] = tmp;
                        }
                }
            }

            Console.WriteLine("sinh vien sap xep theo thu tu giam dan");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien ma {0} co diem tb {1} ", sinhvien[i].maSV, sinhvien[i].tinhTb());
            }
            Console.ReadLine();





            //tim ra sinh vien co chua chu 18I
            for (int i = 0; i < n; i++)
                if (sinhvien[i].maSV.Contains("18IT"))
                    Console.WriteLine("SV ma {0} co diem  Tb la {1} co chua chu 18IT", sinhvien[i].maSV, sinhvien[i].tinhTb());

            Console.ReadLine();
        }
    }
}



