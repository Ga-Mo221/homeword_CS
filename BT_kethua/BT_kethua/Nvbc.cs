using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_kethua
{
    internal class Nvbc : NhanVien
    {
        public static int soluongnvbc;
        private double hesoluong;


        public double HESOLUONG
        {
            set { this.hesoluong = value; }
        }

        public Nvbc() : base() { soluongnvbc++; }


        public double PhuCap()
        {
            double phucap;
            int thamnien = base.tinhthamnien();
            if (thamnien >= 10)
            {
                phucap = (base.luongcoban + 500000) / 10;
            }
            else { phucap = (base.luongcoban + 200000) / 10; }
            return phucap;
        }

        public void nhap()
        {
            base.Nhap();
            Console.Write("He So Luong: ");
            this.hesoluong = double.Parse(Console.ReadLine());
        }

        public double thuclinh()
        {
            double phucap = PhuCap();
            double luong = this.hesoluong * base.luongcoban + phucap;
            return luong;
        }


        public override void Xuat()
        {
            base.Xuat(); // Gọi phương thức Xuat của lớp cha
            Console.WriteLine("He So Luong: " + this.hesoluong);
            Console.WriteLine("Phu Cap: " + PhuCap());
            Console.WriteLine("Luong: " + thuclinh());
        }
    } 
}
