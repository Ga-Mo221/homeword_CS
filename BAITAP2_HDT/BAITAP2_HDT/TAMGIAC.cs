using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP2_HDT
{
    internal class TAMGIAC :HINH {
        public static int demsotamgiac;

        private double a;
        private double b;
        private double c;
        public double A { 
          get { return this.a; }
          set { this.a=value; }
        }
        public double B {
            get { return this.b; }
            set { this.b = value; }
        }
        public double C {
            get { return this.c; }
            set { this.c = value; }
        }
        public TAMGIAC():base() {
            demsotamgiac++;
        }
        public TAMGIAC(String tenhinh,double a,double b, double c):base(tenhinh) {
            this.a = a;
            this.b = b;
            this.c = c;
            demsotamgiac++;
        }
        public TAMGIAC(TAMGIAC tg) {
            this.a = tg.a;
            this.b = tg.b;
            this.c = tg.c;
            demsotamgiac++;
        }
        public override void Nhap() {
            Console.WriteLine("Nhap 3 canh tam giac");
            Console.Write("nhap canh A:");
            this.a = double.Parse(Console.ReadLine());
            Console.Write("nhap canh B:");
            this.b = double.Parse(Console.ReadLine());
            Console.Write("nhap canh C:");
            this.c = double.Parse(Console.ReadLine());
        }
        public override double tinhChuVi() {
            return (this.a + this.b + this.c);
        }
        public override double tinhDienTich()   {
            double P = this.tinhChuVi() / 2;
            return (Math.Sqrt(P*(P-this.a)* (P - this.b)* (P - this.c)));
        }
        public override void Xuat(){
            Console.WriteLine("TAM GIAC");
            Console.WriteLine("Canh A:{0}",this.a);         
            Console.WriteLine("Canh B:{0}", this.b);      
            Console.WriteLine("Canh C:{0}", this.c);
            Console.WriteLine("Chu vi:{0}", this.tinhChuVi());
            Console.WriteLine("Dien tich:{0}", this.tinhDienTich());
        }
    }
}
