using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP2_HDT
{
    internal abstract class HINH
    {
        public abstract double tinhDienTich();
        public abstract double tinhChuVi();

        protected String tenhinh;
        public String TENHINH
        {
            set { this.tenhinh = value; }
            get { return this.tenhinh; }
        }
        public HINH() { }
      public HINH(string tenhinh) {
            this.tenhinh = tenhinh;
        }
       public virtual void Nhap()
        {
            Console.WriteLine("NHAP HINH");
            Console.Write("Nhap ten hinh");
            this.tenhinh = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("XUAT HINH");
            Console.Write("Ten hinh:{0}",this.tenhinh);
        }
    }
}
