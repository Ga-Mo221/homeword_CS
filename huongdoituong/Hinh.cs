using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class Hinh
    {
        protected String tenhinh;


        public string TENHINH
        {
            set { this.tenhinh = value; }
            get { return this.tenhinh;  }
        }

        public Hinh() { }

        public Hinh(String tenhinh)
        {
            this.tenhinh = tenhinh;
        }

        public void nhap()
        {
            Console.WriteLine("ten: ");
            this.tenhinh = Console.ReadLine();
        }

        public void xuat()
        {
            Console.WriteLine("ten hinh: " + this.tenhinh);
        }
    }
}
