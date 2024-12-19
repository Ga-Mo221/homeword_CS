using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_L_ung_vien
{
    internal class EXPERIENCE : CANDIDATE
    {
        private int SoNamKinhNghiem;
        private String KyNang;
        private String NoiLamViec;


        public int SONAMKINHNGHIEM
        {
            set { this.SoNamKinhNghiem = value; }
            get { return this.SoNamKinhNghiem; }
        }
        public String KYNANG
        {
            set { this.KyNang = value; }
            get { return this.KyNang; }
        }
        public String NOILAMVIEC
        {
            set { this.NoiLamViec = value; }
            get { return this.NoiLamViec; }
        }


        /// <summary>
        /// hàm không đối
        /// </summary>
        public EXPERIENCE() : base() { }


        /// <summary>
        /// nhập của EXPRIENCE
        /// </summary>
        public void nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            base.Nhap();
            Console.Write("Số Năm Kinh Nghiệm  : ");
            this.SoNamKinhNghiem = Int16.Parse(Console.ReadLine());
            Console.Write("Kỹ Năng             : ");
            this.KyNang = Console.ReadLine();
            Console.Write("Nơi Làm Việc        : ");
            this.NoiLamViec = Console.ReadLine();
        }


        public override void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            base.Xuat();
            Console.WriteLine("Số năm Kinh Nghiệm  : " + this.SoNamKinhNghiem);
            Console.WriteLine("Kỹ Năng             : " + this.KyNang);
            Console.WriteLine("Nơi Làm Việc        : " + this.NoiLamViec);
        }
    }
}
