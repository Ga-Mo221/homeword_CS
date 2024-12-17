using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_L_ung_vien
{
    internal class CANDIDATE
    {
        protected int staffCode;
        protected String Hoten;
        protected DateTime NgaySing;
        protected String QueQuan;
        protected String Sodienthoai;
        protected String Email;


        public int STAFFCODE
        {
            set { this.staffCode = value; }
            get { return this.staffCode; }
        }
        public String HOTEN
        {
            set { this.Hoten = value; }
            get { return this.Hoten; }
        }
        public DateTime NGAYSINH
        {
            set { this.NgaySing = value; }
            get { return this.NgaySing; }
        }
        public String QUEQUAN
        {
            set { this.QueQuan = value; }
            get { return this.QueQuan; }
        }
        public String SODIENTHOAI
        {
            set { this.Sodienthoai = value; }
            get { return this.Sodienthoai; }
        }
        public String EMAIL
        {
            set { this.Email = value; }
            get { return this.Email; }
        }


        /// <summary>
        /// hàm không đối
        /// </summary>
        public CANDIDATE() { } 

        /// <summary>
        /// Nhập của CANDIDATE
        /// </summary>
        public void Nhap()
        {
            Console.Write("Họ Tên              : ");// nhap Họ tên
            this.Hoten = Console.ReadLine();

            Console.Write("Ngày Sinh           : ");// nhap ngay sinh(dd/MM/yyyy)
            string NS = Console.ReadLine();
            this.NgaySing = DateTime.ParseExact(NS,"dd/MM/yyyy", null);

            Console.Write("Quê Quán            : ");// nhập quê quán
            this.QueQuan = Console.ReadLine();

            Console.Write("Số Điện Thoại       : ");// nhập số điện thoại
            this.Sodienthoai = Console.ReadLine();

            Console.Write("Email               : ");// nhập email
            this.Email = Console.ReadLine();
        }// end nhập

        /// <summary>
        /// xuất của CANDIDATE
        /// </summary>
        public virtual void Xuat()
        {
            Console.WriteLine("StaffCode           : " + this.staffCode);
            Console.WriteLine("Họ và Tên           : " + this.Hoten);
            Console.WriteLine("Ngày Sinh           : " + this.NgaySing.ToString("dd/MM/yyyy"));
            Console.WriteLine("Quê Quán            : " + this.QueQuan);
            Console.WriteLine("Số Điện Thoại       : " + this.Sodienthoai);
            Console.WriteLine("Email               : " + this.Email);
        }// end xuất
    }
}
