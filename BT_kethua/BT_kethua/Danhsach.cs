using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_kethua
{
    internal class Danhsach
    {
        private NhanVien[] dsnv = new NhanVien[100];

        public void nhap()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("\t1. Nhan vien bien che");
                Console.WriteLine("\t2. Nhan vien hop dong");
                Console.WriteLine("\t3. Thoat");
                choice = Int16.Parse(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        {
                            int slnvbc = Nvbc.soluongnvbc;
                            int slnvhd = Nvhd.soluongnvhd;
                            int rear = slnvbc + slnvhd;
                            Console.WriteLine("So Luong Nhan Vien: ");
                            int x = Int16.Parse(Console.ReadLine());
                            for (int i = rear; i < rear+x; i++)
                            {
                                Nvbc nvbc = new Nvbc();
                                nvbc.nhap();
                                dsnv[i] = nvbc;
                            }
                            break;
                        }
                    case 2:
                        {
                            int slnvbc = Nvbc.soluongnvbc;
                            int slnvhd = Nvhd.soluongnvhd;
                            int rear = slnvbc + slnvhd;
                            Console.WriteLine("So Luong Nhan Vien: ");
                            int x = Int16.Parse(Console.ReadLine());
                            for (int i = rear; i < rear + x; i++)
                            {
                                Nvhd nvhd = new Nvhd();
                                nvhd.nhap();
                                dsnv[i] = nvhd;
                            }
                            break;
                        }
                    case 3:
                        break;
                }
                
            } while (choice != 3);
        }

        public void xuat()
        {
            Console.Clear();
            int slnvbc = Nvbc.soluongnvbc;
            int slnvhd = Nvhd.soluongnvhd;
            int rear = slnvbc + slnvhd;

            for (int i = 0; i < rear; i++)
            {
                dsnv[i].Xuat();
                Console.WriteLine();
            }
        }

        public double Tongquyluong()
        {
            Console.Clear();
            double Tong = 0;
            int slnvbc = Nvbc.soluongnvbc;
            int slnvhd = Nvhd.soluongnvhd;
            int rear = slnvbc + slnvhd;
            for (int i = 0; i < rear; i++)
            {
                if (dsnv[i] is Nvbc)
                {
                    Tong += ((Nvbc)dsnv[i]).thuclinh();
                }
                else if (dsnv[i] is Nvhd)
                {
                    Tong += ((Nvhd)dsnv[i]).thuclinh();
                }
            }
            Console.WriteLine("Tong quy luong la {0}VND" , Tong);
            return Tong;
        }

        public void ThongKe()
        {
            Console.Clear();
            int slnvbc = Nvbc.soluongnvbc;
            int slnvhd = Nvhd.soluongnvhd;
            int rear = slnvbc + slnvhd;
            Console.WriteLine("Co {0} nhan vien bien che", slnvbc);
            Console.WriteLine("Co {0} nhan vien hop dong", slnvhd);
            Console.WriteLine("Co tong cong {0} nhan vien", rear);
        }

        public NhanVien Tim()
        {
            Console.Clear();
            Console.WriteLine("Ban muon tim ai: ");
            string name = Console.ReadLine();
            int slnvbc = Nvbc.soluongnvbc;
            int slnvhd = Nvhd.soluongnvhd;
            int rear = slnvbc + slnvhd;
            for (int i = 0; i < rear; i++)
            {
                if (string.Compare(name, dsnv[i].TEN) == 0)
                {
                    dsnv[i].Xuat();
                    return dsnv[i];
                }
            }
            Console.WriteLine("khong co nguoi ten '{0}' nay", name);
            return null;
        }

        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("Nhap id: ");
            string id = Console.ReadLine();
            int slnvbc = Nvbc.soluongnvbc;
            int slnvhd = Nvhd.soluongnvhd;
            int rear = slnvbc + slnvhd;
            for (int i = 0; i < rear; i++)
            {
                if (dsnv[i].ID.ToLower().Contains(id.ToLower()))
                {
                    Console.WriteLine("Nhan vien can xoa");
                    dsnv[i].Xuat();
                    if (dsnv[i] is Nvbc)
                    {
                        Nvbc.soluongnvbc--;
                    }
                    else if (dsnv[i] is Nvhd)
                    {
                        Nvhd.soluongnvhd--;
                    }
                    for (int j = i; j < rear-1; j++)
                    {
                        dsnv[j] = dsnv[j+1];
                    }
                    rear--;
                    break;
                }
            }
            Console.WriteLine("khong co nhan vien co id la "+ id);
        }
    }
}
