using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class chunhat : Hinh
    {
        public static int solansudung;
        private double a;
        private double b;


        public double A
        {
            set { this.a = value; }
            get { return this.a; }
        }
        public double B
        {
            set { this.b = value; } 
            get { return this.b; }
        }


        public chunhat(chunhat cn)
        {
            this.a = cn.a;
            this.b = cn.b;
            solansudung++;
        }


        public chunhat() : base() { solansudung++; }


        public chunhat(string tenhinh, double a, double b) : base(tenhinh)
        {
            this.a = a;
            this.b = b;
            base.tenhinh = tenhinh;
            solansudung++;
        }


        public void nhap()
        {
            base.nhap();
            this.a = double.Parse(Console.ReadLine());
            this.b = double.Parse(Console.ReadLine());
        }


        public double chuvi()
        {
            return this.a + this.b;
        }


        public double dientich()
        {
            return (this.a + this.b) * 2;
        }

        
        public void xuat()
        {
            base.xuat();
            Console.WriteLine("chieu dai hinh vuong = " + this.a);
            Console.WriteLine("chieu rong hinh vuong = " + this.b);
            Console.WriteLine("chu vi hinh vuong = " + chuvi());
            Console.WriteLine("dien tich hinh chu nhat = " + dientich());
        }
    }
}
