using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BT_kethua
{
    internal class BaiTap
    {
        static void end()
        {
            Console.WriteLine("bam phim bat ki de thoat...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Danhsach DS = new Danhsach();
            int choicee;
            do
            {
                Console.Clear();
                Console.WriteLine("\t1.Nhap");
                Console.WriteLine("\t2.Xuat");
                Console.WriteLine("\t3.Sap Xep");
                Console.WriteLine("\t4.Tong Quy Luong");
                Console.WriteLine("\t5.Thong Ke");
                Console.WriteLine("\t6.Tim");
                Console.WriteLine("\t7.Xoa");
                Console.WriteLine("\t8.Thoat");
                Console.Write("Chon: ");
                choicee = Int16.Parse(Console.ReadLine());

                switch (choicee)
                {
                    case 1:
                        {
                            DS.nhap();
                            end();
                            break;
                        }
                    case 2:
                        {
                            DS.xuat();
                            end();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            DS.sapxep();
                            Console.WriteLine("sap xep thanh cong");
                            end();
                            break;
                        }
                    case 4:
                        {
                            DS.Tongquyluong();
                            end();
                            break;
                        }
                    case 5:
                        {
                            DS.ThongKe();
                            end();
                            break;
                        }
                    case 6:
                        {
                            DS.Tim();
                            end();
                            break;
                        }
                    case 7:
                        {
                            DS.xoa();
                            end();
                            break;
                        }
                    case 8:
                        {
                            break;
                        }
                }

            } while (choicee != 8);
        }
    }
}
