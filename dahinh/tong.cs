using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dahinh
{
    internal class tong
    {
        private int a; private int b; private int c;

        public int A
        {
            set { this.a = value; }
            get { return this.a; }
        }
        public int B
        {
            set { this.b = value; }
            get { return this.b; }
        }
        public int C
        {
            set { this.c = value; }
            get { return this.c; }
        }

        public int Tong(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Tong(int a, int b)
        {
            return a + b;
        }
    }
}
