using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_L_ung_vien
{
    internal class INTERN : CANDIDATE
    {
        private int NamDuKienTN;
        private String NganhHoc;
        private String HocKy;
        private String Truong;


        public int NAMDUKIENTN
        {
            set { this.NamDuKienTN = value; }
            get { return this.NamDuKienTN; }
        }
        public String NGANHHOC
        {
            set { this.NganhHoc = value; }
            get { return this.NganhHoc; }
        }
        public String HOCKY
        {
            set { this.HocKy = value; }
            get { return this.HocKy; }
        }
        public String TRUONG
        {
            set { this.Truong = value; }
            get { return this.Truong; }
        }


        /// <summary>
        /// hàm không đối
        /// </summary>
        public INTERN() : base() { }


        /// <summary>
        /// nhập của INTERN
        /// </summary>
        public void nhap()
        {
            base.Nhap();
            Console.Write("Năm Tốt Nghiệp DK   : ");
            this.NamDuKienTN = Int16.Parse(Console.ReadLine());
            Console.Write("Ngành Học           : ");
            this.NganhHoc = Console.ReadLine();
            Console.Write("Kỳ Học              : ");
            this.HocKy = Console.ReadLine();
            Console.Write("Trường              : ");
            this.Truong = Console.ReadLine();
        }


        /// <summary>
        /// Xuất của INTERN
        /// </summary>
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Năm Tốt Nghiệp DK   : " + this.NamDuKienTN);
            Console.WriteLine("Ngành Học           : " + this.NganhHoc);
            Console.WriteLine("Học Kỳ              : " + this.HocKy);
            Console.WriteLine("Trường              : " + this.Truong);
        }
    }
}
