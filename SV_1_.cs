﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    class SV_1_
    {
        public String maSV;
        float toan;
        float ly;
        float hoa;
        //default constructors
        public SV_1_()
        {
            this.maSV = "01";
            this.toan = (float)7.5;
            this.ly = (float)8.5;
            this.hoa = (float)9.5;
        }
        //tham so hoa constructors
        public SV_1_(String maSV, float toan, float ly, float hoa)
        {
            this.maSV = maSV;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }
        //viet ham nhap
        //viet ham tinh diem trung binh
        // viet ham in
        public void nhapthongtin()
        {
            Console.WriteLine("nhap ma sinh vien");
            this.maSV = Console.ReadLine();
            Console.WriteLine("nhap diem toan");
            this.toan = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem ly");
            this.ly = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem hoa");
            this.hoa = float.Parse(Console.ReadLine());
        }
        public float tinhTb()
        {
            float S = 0;
            S = (this.toan + this.ly + this.hoa) / 3;
            return S;
        }
        public void In()
        {
            Console.WriteLine("Ma {0} co diem trung binh la {1}", this.maSV, this.tinhTb());
        }

    }
}


