using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class main
    {
        static void Main(string[] args)
        {
            /*
            SinhVien sv = new SinhVien();
            sv.MASV = "1234";
            sv.NAME = "Nguyen van Hau";
            sv.TOAN = 10;
            sv.LY = 10;
            sv.HOA = 10;
            sv.xuat();


            Console.WriteLine();            
            SinhVien sv1 = new SinhVien("vn123","hoang thuong",10,9,9);
            sv1.xuat();


            Console.WriteLine();
            SinhVien sv2 = new SinhVien(sv1);
            sv2.xuat();

            SinhVien[] list;
            Console.Write("so sinh vien: ");
            int n = Int16.Parse(Console.ReadLine());
            list = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1);
                SinhVien sv3 = new SinhVien();
                sv3.nhap();
                list[i] = sv3;
            }
            */
            tamgiac tg1 = new tamgiac();
            tg1.nhap();
            hinhtron ht = new hinhtron();
            ht.nhap();
            chunhat cn = new chunhat();
            cn.nhap();
            tg1.xuat();
            ht.xuat();
            cn.xuat();

            Console.ReadLine();
        }
    }
}
