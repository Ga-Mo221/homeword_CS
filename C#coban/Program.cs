using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_coban
{
    internal class Program
    {
        static int[] M;
        static int n;

        /// <summary>
        /// ham nay la ham nhap vao gia tri mang
        /// </summary>
        static void input()
        {
            Console.WriteLine("nhap gia tri tung phan tu cho mang M");
            for (int i = 0; i < n; i++)
            {
                Console.Write("M[{0}] = ", i + 1);
                M[i] = Int32.Parse(Console.ReadLine());
            }
        }// end cua input

        /// <summary>
        /// ham hien thi gia tri cua mang
        /// </summary>
        static void output()
        {
            Console.WriteLine("gia tri cua mang da nhap la");
            for (int i = 0;i < n; i++)
            {
                Console.Write("M[{0}] = {1}",i+1,M[i]+" => ");
            }
            Console.WriteLine();
        }// end cua output

        /// <summary>
        /// tim x co trong mang khong
        /// </summary>
        /// <param name="Find"></param>
        static void find()
        {
            int Find;
            Console.Write("nhap vao so muon tim: ");
            Find = Convert.ToInt32(Console.ReadLine());
            List<int> vitri = new List<int>();//cach tao ra list trong
            for (int i = 0; i < n; i++)
            {
                if (M[i] == Find)
                {
                    vitri.Add(i);// them bien i vao list vitri
                }
            }
            if (vitri.Count == 0)// vitri.Count la so luong phan tu trong list vitri
            {
                Console.WriteLine("khong co trong mang");
            }
            else
            {
                Console.WriteLine("co trong mang");
                Console.WriteLine("o vi tri");
                for (int i = 0; i < vitri.Count; i++)
                {
                    Console.Write(vitri[i] + " ");
                }
            }
        }//end cua find

        
        //static bool find(int i)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        if (M[j] == i)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}//end cua find
        
        /// <summary>
        /// tinh tong cua cac phan tu trong mang
        /// </summary>
        static void sum()
        {
            int sum = 0;
            for (int i = 0;i<n;i++)
            {
                sum += M[i];
            }
            Console.WriteLine("tong cac phan tu trong mang la : " + sum);
        }//end cua sum

        static void xoa()
        {
            Console.Write("nhap so can xoa");
            int x = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                if (M[i] == x)
                {
                    for (int k = i; k < n - 1; k++)
                    {
                        M[k] = M[k + 1];
                    }
                    n--;
                    i--;
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(M[i]);
            }

        }//end xoa


        static void sapxep()
        {
            Array.Sort(M);//sap xep tang dan
            Array.Reverse(M);// dao nguoc mang
            Console.WriteLine("mang da duoc sap xep theo thu tu tang dan");
            for (int i = 0; i < n; i++)
            {
                Console.Write(M[i]+" ");
            }
        }
        static int menu()
        {
            int choice;
            Console.WriteLine("chon chuc nang");
            Console.WriteLine("1. tim so");
            Console.WriteLine("2. tinh tong");
            Console.WriteLine("3. hien thi mang");
            Console.WriteLine("4. xoa mot phan tu");
            Console.WriteLine("5. sap xep mang");
            Console.WriteLine("0. de dung lai");
            Console.Write("lua chon cua ban la:");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("nhap so phan tu mang: ");
            //console.readline(); hieu kieu du lieu la char
            n = Convert.ToInt32(Console.ReadLine()); //chuyen char thanh int32
            //n = Int32.Parse(Console.ReadLine());   // cach 2

            M = new int[n];
            input();
            int choice;
            do
            {
                choice = menu();
                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("chuong trinh dung lai");
                            break;
                        }
                    case 1:
                        {
                            find();
                            break;
                        }
                    case 2:
                        {
                            sum();
                            break;
                        }
                    case 3:
                        {
                            sum();
                            break;
                        }
                    case 4:
                        {
                            xoa();
                            break;
                        }
                    case 5:
                        {
                            sapxep();
                            break;
                        }
                }
            }while ( choice != 0);

            

            Console.ReadKey();
        }
    }// end cua main
}// end cua program
