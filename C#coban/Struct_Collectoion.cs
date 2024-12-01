using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_coban
{
    internal class Struct_Collectoion
    {

        struct sinhvien
        {
            public string hoten;
            public string gioitinh;
            public long CCCD;
            public DateTime Ngaysinh;

            public sinhvien(string ht, string gt, long cccd, DateTime ns)
            {
                hoten = ht;
                gioitinh = gt;
                CCCD = cccd;
                Ngaysinh = ns;
            }

            public void xuat()
            {
                Console.Write("Ho ten: "+ hoten +", ");
                Console.Write("Gioi Tinh: " + gioitinh + ", ");
                Console.Write("CCCD: " +CCCD + ", ");
                Console.WriteLine("Ngay sinh" + Ngaysinh.ToString("MM/dd/yyy"));
            }

            public void nhap()
            {
                Console.Write("ten: ");
                hoten = Console.ReadLine();
                Console.Write("gioi tinh: ");
                gioitinh = Console.ReadLine();
                Console.Write("cccd: ");
                CCCD = long.Parse(Console.ReadLine());
                Console.Write("ngay sinh: ");
                Ngaysinh = DateTime.Parse(Console.ReadLine());
            }

            public string checkBirtday()
            {
                if (Ngaysinh.Day == DateTime.Today.Day && Ngaysinh.Month == DateTime.Today.Month)
                {
                    return "Happy Birtday";
                }
                else
                {
                    return "good day";
                }
            }
        }//end struct sinhvien

        static void Main(string[] args)
        {
            sinhvien sv;
            sv.hoten = "le a";
            sv.gioitinh = "nam";
            sv.CCCD = 7568;
            sv.Ngaysinh = DateTime.Parse("1/4/2000");

            Console.WriteLine("Ho ten: {0}, Gioi tinh: {1}, CCCD: {2}, Ngay sinh: {3}",
                sv.hoten,sv.gioitinh,sv.CCCD,sv.Ngaysinh.ToString("dd/MM/yyyy"));

            sinhvien sv1 = new sinhvien("le b", "nu", 45674, DateTime.Parse("4/1/1777"));

            Console.WriteLine("Ho ten: {0}, Gioi tinh: {1}, CCCD: {2}, Ngay sinh: {3}", 
                sv1.hoten, sv1.gioitinh, sv1.CCCD, sv1.Ngaysinh.ToString("dd/MM/yyyy"));

            sv1.xuat();
            string Sv1 = sv1.checkBirtday();
            Console.WriteLine(Sv1);
            sinhvien sv2 = new sinhvien();
            sv2.nhap();
            sv2.xuat();

            Console.ReadKey();
        }//end main
    }
}
