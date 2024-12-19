using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP2_HDT {    
    internal class TRON :HINH {
        private double r;
        public double R  {
            set { this.r = value; }
            get { return this.r; }
        }
        public TRON():base() { }
        public TRON(String tenhinh,double r):base(tenhinh) {
            this.r = r;
        }
        public TRON(TRON tron) {
            this.r = tron.r;
           
        }
        public override void Nhap() {
            base.Nhap();
            Console.WriteLine("HINH TRON");
            Console.Write("Nhap ban kinh r:");
            this.r =double.Parse(Console.ReadLine());
        }
        public override double tinhChuVi() {
            return (2 * Math.PI * this.r);
        }
        public override double tinhDienTich() {
            return (Math.PI * this.r* this.r);
        }
        public override void Xuat() {
            base.Xuat();
            Console.WriteLine("Ban kinh r:{0}",this.r);
            Console.WriteLine("Chu vi:{0}", this.tinhChuVi());
            Console.WriteLine("Dien tich:{0}", this.tinhDienTich());
        }
    }
}
