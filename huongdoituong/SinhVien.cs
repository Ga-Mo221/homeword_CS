using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace huongdoituong
{
    internal class SinhVien
    {
        /// <summary>
        /// trường dữ liệu dâtField => thuộc tính
        /// public static: là không thuộc một đối tượng nào hết, nằm ở một ô nhớ riêng (thuộc tính tỉnh) được dùng chung
        /// private : có tác dụng trong lop sinhvien thoi // nên dùng
        /// protected: cho kế thừa
        /// public: ai dung cung duoc
        /// internal: chỉ sử dụng trong chương trình(chương trình khác không dùng được)
        /// internal protected: ??
        /// </summary>
        private String masv;
        private String name;
        private double toan;
        private double ly;
        private double hoa;
        private double DTB;


        /// <summary>
        /// Thuộc tính của lớp properties
        /// khuyến cáo nên dùng publlic để đọc  và ghi dữ liệu
        /// </summary>
        public String MASV
        {
            set { this.masv = value; }// ghi dữ liệu
            get { return this.masv; }// đọc dữ liệu
        }

        public String NAME
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public double TOAN
        {
            set { this.toan = value; }
            get { return this.toan; }
        }

        public double LY
        {
            set { this.ly = value; }
            get { return this.ly ; }
        }

        public double HOA
        {
            set { this.hoa = value; }
            get { return this.hoa; }
        }

        public void xuat()// hàm gọi là hành vi
        {
            Console.WriteLine("ma sinh vien: " + this.masv);
            Console.WriteLine("ho va ten   : " + this.name);
            Console.WriteLine("diem toan   : " + this.toan);
            Console.WriteLine("diem ly     : " + this.ly);
            Console.WriteLine("diem hoa    : " + this.hoa);
            Console.WriteLine("diem tb     : " + dtb());
        }

        public double dtb()
        {
            return DTB = (this.toan + this.ly +  this.hoa)/3;
        }

        // hàm không đối
        public SinhVien()// tạo ra một đối tượng không có thuộc tính
        { }


        // hàm khởi tạo có đối
        public SinhVien(string MASV, string NAME, double TOAN, double LY, double HOA)
        {
            this.masv = MASV;
            this.name = NAME;
            this.toan = TOAN;
            this.ly = LY;
            this.hoa = HOA;
        }

        //sao chep
        public SinhVien(SinhVien sv)
        {
            this.masv = sv.masv;
            this.name = sv.name;
            this.toan = sv.toan;
            this.ly = sv.ly;
            this.hoa = sv.hoa;
        }

        public void nhap()
        {
            Console.Write("id : ");
            this.masv = Console.ReadLine();
            Console.Write("name : ");
            this.name = Console.ReadLine();
            Console.Write("diem toan : ");
            this.toan = double.Parse(Console.ReadLine());
            Console.Write("diem ly : ");
            this.ly = double.Parse(Console.ReadLine());
            Console.Write("diem hoa : ");
            this.hoa= double.Parse(Console.ReadLine());
        }

    }// end class SinhVien
}
