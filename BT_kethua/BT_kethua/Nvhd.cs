using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_kethua
{
    internal class Nvhd : NhanVien
    {
        public static int soluongnvhd;
        private double mucluong;


        public double MUCLUONG
        {
            set { this.mucluong = value; }
        }

        public Nvhd() : base() { soluongnvhd++; }

        public double PhuCap() 
        {
            double phucap;
            int thamnien = base.tinhthamnien();
            if (thamnien >= 2)
            {
                phucap = (base.luongcoban + 200000) / 10;
            }
            else { phucap = (base.luongcoban + 100000) / 10; }
            return phucap;
        }

        public void nhap()
        {
            base.Nhap();
            Console.Write("Muc Luong: ");
            this.mucluong = double.Parse(Console.ReadLine());
        }

        public double thuclinh()
        {
            double phucap = PhuCap();
            double luong = this.mucluong * base.luongcoban + phucap;
            return luong;
        }

        public override void Xuat()
        {
            base.Xuat(); // Gọi phương thức Xuat của lớp cha
            Console.WriteLine("Muc Luong: " + this.mucluong);
            Console.WriteLine("Phu Cap: " + PhuCap());
            Console.WriteLine("Luong: " + thuclinh());
        }
    }
}
