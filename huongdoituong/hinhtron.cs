using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class hinhtron : Hinh
    {
        public static int solansudunght;
        private double r;
        const double Pi = Math.PI;


        public double R
        {
            set { this.r = value; }
            get { return this.r; }
        }



        public hinhtron() : base() { solansudunght++; }


        public hinhtron(hinhtron ht)
        {
            this.r = ht.r;
            solansudunght++;
        }


        public hinhtron(string tenhinh, double r): base(tenhinh) 
        {
            this.r = r;
            base.tenhinh = tenhinh;
            solansudunght++;
        }


        public void nhap()
        {
            base.nhap();
            this.r = double.Parse(Console.ReadLine());
        }


        public double chuvi()
        {
            return 2 * this.r * Pi;
        }


        public double dientich()
        {
            return Math.Pow(this.r,2) * Pi;
        }


        public void xuat()
        {
            base.xuat();
            Console.WriteLine("ban kinh hinh tron = " + this.r);
            Console.WriteLine("chu vi hinh tron = {0:F2}" , chuvi());
            Console.WriteLine("dien tich hinh tron = {0:F2} ", dientich());
        }
    }
}
