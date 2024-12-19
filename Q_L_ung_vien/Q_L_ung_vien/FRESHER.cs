using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_L_ung_vien
{
    internal class FRESHER : CANDIDATE
    {
        private int NamTotNghiep;
        private String XepLoai;
        private String Truongtotnghiep;


        public int NAMTOTNGHIEP
        {
            set { this.NamTotNghiep = value; }
            get { return this.NamTotNghiep; }
        }
        public String XEPLOAI
        {
            set { this.XepLoai = value; }
            get { return this.XepLoai; }
        }
        public String TRUONGTOTNGHIEP
        {
            set { this.Truongtotnghiep = value; }
            get { return this.Truongtotnghiep; }
        }

        /// <summary>
        /// hàm không đối
        /// </summary>
        public FRESHER() : base() { }


        /// <summary>
        /// Nhập của FRESHER
        /// </summary>
        public void nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            base.Nhap();
            Console.Write("Năm Tốt Nghiệp      : ");
            this.NamTotNghiep = Int16.Parse(Console.ReadLine());
            Console.Write("Xếp Loại            : ");
            this.XepLoai = Console.ReadLine();
            Console.Write("Trường Tốt Nghiệp   : ");
            this.Truongtotnghiep = Console.ReadLine();
        }


        /// <summary>
        /// Xuất của FRESHER
        /// </summary>
        public override void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            base.Xuat();
            Console.WriteLine("Năm Tốt Nghiệp      : " + this.NamTotNghiep);
            Console.WriteLine("Xếp Loại            : " + this.XepLoai);
            Console.WriteLine("Trường Tốt Nghiệp   : " + this.Truongtotnghiep);
        }
    }
}
