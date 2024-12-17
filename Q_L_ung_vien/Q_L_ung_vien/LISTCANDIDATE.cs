using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_L_ung_vien
{
    internal class LISTCANDIDATE
    {
        private List<CANDIDATE> liststaff = new List<CANDIDATE>();
        public static int index = 0;


        /// <summary>
        /// hàm không đối
        /// </summary>
        public LISTCANDIDATE() { }


        /// <summary>
        /// xoá console
        /// </summary>
        public void start()
        {
            Console.Clear();
        }// end start


        /// <summary>
        ///  kết thúc
        /// </summary>
        public void end()
        {
            Console.WriteLine("\n\tBam phim bat ki de thoat...");
            Console.ReadKey();
            Console.Clear();
        }// end end


        /// <summary>
        /// nhập của List
        /// </summary>
        public void nhap()
        {
            int staffcode;
            int size;
            Console.WriteLine("Số Lượng Ứng Viên: ");
            size = Int16.Parse(Console.ReadLine());

            end();
            for (int i = 0; i < size; i++)
            {
                Console.Write("StaffCode           : ");// nhap loại
                staffcode = Int16.Parse(Console.ReadLine()); 
                

                switch (staffcode)
                {
                    case 1:
                        {
                            EXPERIENCE ex = new EXPERIENCE();
                            ex.STAFFCODE = staffcode;
                            ex.nhap();
                            liststaff.Add(ex);
                            index++;
                            end();
                            break;
                        }
                    case 2:
                        {
                            FRESHER fre = new FRESHER();
                            fre.STAFFCODE = staffcode;
                            fre.nhap();
                            liststaff.Add(fre);
                            index++;
                            end();
                            break;
                        }
                    case 3:
                        {
                            INTERN Int = new INTERN();
                            Int.STAFFCODE = staffcode;
                            Int.nhap();
                            liststaff.Add(Int);
                            index++;
                            end();
                            break;  
                        }
                }
            }
        }// end nhập

        
        /// <summary>
        /// xuất danh sách ứng viên
        /// </summary>
        public void xuat()
        {
            start();
            foreach (CANDIDATE i in liststaff)
            {
                if (i is EXPERIENCE)
                {
                    ((EXPERIENCE)i).Xuat();
                    Console.WriteLine("\n===============================================\n");
                }
                if (i is FRESHER)
                {
                    ((FRESHER)i).Xuat();
                    Console.WriteLine("\n===============================================\n");
                }
                if (i is INTERN)
                {
                    ((INTERN)i).Xuat();
                    Console.WriteLine("\n===============================================\n");
                }
            }

        }// end xuất


        /// <summary>
        /// xoá ứng viên theo tên
        /// </summary>
        public void xoa()
        {

        }// end xoá


        /// <summary>
        /// tìm kiếm ứng viên theo tên
        /// </summary>
        public void tim()
        {

        }// end tìm
    }
}
