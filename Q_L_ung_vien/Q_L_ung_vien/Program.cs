using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_L_ung_vien
{   
    internal class Program
    {
        /// <summary>
        /// menu chính
        /// </summary>
        static void menu()
        {
            Console.WriteLine("===========MENU===========");
            Console.WriteLine("\t1. Nhập");
            Console.WriteLine("\t2. Xuất");
            Console.WriteLine("\t3. Xoá");
            Console.WriteLine("\t4. Tìm");
            Console.WriteLine("\t5. Thoát");
            Console.WriteLine("==========================");
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            LISTCANDIDATE list = new LISTCANDIDATE();
            int choice;
            do
            {
                menu();
                Console.Write("Chon: ");
                choice = Int16.Parse(Console.ReadLine());
                Console.Clear();


                switch (choice)
                {
                    case 1:
                        {
                            list.nhap();
                            list.end();
                            break;
                        }
                    case 2:
                        {
                            list.xuat();
                            list.end();
                            break;
                        }
                    case 3:
                        {
                            list.xoa();
                            list.end();
                            break;
                        }
                    case 4:
                        {
                            list.tim();
                            list.end();
                            break;
                        }
                    case 5:
                        break;
                } 
            }while (choice != 5);

        }
    }
}
