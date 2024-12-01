using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class tamgiac
    {
        public static int solansudungtg;
        private double a;
        private double b;
        private double c;


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
            
        public double C
        {
            set { this.c = value; }
            get { return this.c; }
        }


        public tamgiac() { solansudungtg++; }// ham khong doi

        public tamgiac(double a , double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
            solansudungtg++;
        }



        public tamgiac(tamgiac tg)
        {
            this.a = tg.a; this.b = tg.b; this.c = tg.c;
            solansudungtg++;
        }


        public void nhap()
        {
            this.a = double.Parse(Console.ReadLine());
            this.b = double.Parse(Console.ReadLine());
            this.c = double.Parse(Console.ReadLine());
        }


        public double dientich()
        {
            double s = (this.a + this.b + this.c) / 2; // tính nửa chu vi tam giác
            return Math.Sqrt(s * (s - this.a) * (s - this.b) * (s - this.c)); // tính diện tích theo công thức Heron
        }


        public double chuvi()
        {
            return this.a + this.b + this.c;
        }


        public void xuat()
        {
            Console.WriteLine("canh a cua tam giac = " + this.a);
            Console.WriteLine("canh b cua tam giac = " + this.b);
            Console.WriteLine("canh c cua tam giac = " + this.c);
            Console.WriteLine("chu vi tam giac = {0:F2}", chuvi());
            Console.WriteLine("dien tich tam giac = {0:F2}", dientich());
        }
    }
}
