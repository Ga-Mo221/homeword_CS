using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BT_kethua
{
    internal class NhanVien
    {
        protected string id;
        protected string ten;
        protected DateTime ngaysinh;
        protected DateTime ngayvao;
        protected string gioitinh;
        protected string cmdn;
        protected double luongcoban;


        public string ID
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string TEN
        {
            set { this.ten = value; }
            get { return this.ten; }
        }

        public DateTime NGAYSINH
        {
            set { this.ngaysinh = value; }
            get { return this.ngaysinh; }
        }

        public DateTime NGAYVAO
        {
            set { this.ngayvao = value; }
            get { return this.ngayvao; }
        }

        public string GIOITINH
        {
            set { this.gioitinh = value; }
            get { return this.gioitinh; }
        }

        public string CMND
        {
            set { this.cmdn = value; }
            get { return this.cmdn; }
        }

        public double LUONGCOBAN
        {
            set { this.luongcoban = value; }
            get { return this.luongcoban; }
        }


        public NhanVien() { }// ham khong doi

        // ham co doi
        public NhanVien(string id, string ten, DateTime ngaysinh, DateTime ngayvao, string gioitinh, string cmnd, double luongcoban)
        {
            this.id = id;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.ngayvao = ngayvao;
            this.gioitinh = gioitinh;
            this.cmdn = cmnd;
            this.luongcoban = luongcoban;
        }

        public NhanVien(NhanVien nv)// ham sao chep
        {
            this.id = nv.id;
            this.ten = nv.ten;
            this.ngaysinh = nv.ngaysinh;
            this.ngayvao = nv.ngayvao;
            this.gioitinh = nv.gioitinh;
            this.cmdn = nv.cmdn;
            this.luongcoban = nv.luongcoban;
        }


        public void Nhap()
        {
            Console.Write("Ma           : ");// nhap ma
            this.id = Console.ReadLine();

            Console.Write("Ten          : ");// nhap ten
            this.ten = Console.ReadLine();

            Console.Write("Ngay Sinh    : ");// nhap ngay sinh(MM/dd/yyyy)
            this.ngaysinh = DateTime.Parse(Console.ReadLine());

            Console.Write("Ngay Vao     : ");// nhap ngay vao(dd/MM/yyyy)
            string Nv = Console.ReadLine();
            this.ngayvao = DateTime.ParseExact(Nv, "dd/MM/yyyy", null);

            Console.Write("Gioi Tinh    : ");// nhap gioi tinh
            this.gioitinh = Console.ReadLine();

            Console.Write("CMND         : ");// nhap cmnd
            this.cmdn = Console.ReadLine();

            Console.Write("Luong Co Ban : ");// nhap luong co ban
            this.luongcoban = double.Parse(Console.ReadLine());
        }


        public int tinhthamnien()
        {
            int thamnien;
            DateTime now = DateTime.Now;
            thamnien = now.Year - this.ngayvao.Year;

            if (now.Month < this.ngayvao.Month || (now.Month == this.ngayvao.Month && now.Day < this.ngayvao.Day))
            {
                    thamnien--;
            }
            return thamnien;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma: " + this.id);
            Console.WriteLine("Ten: " + this.ten);
            Console.WriteLine("Ngay Sinh: " + this.ngaysinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay Vao: " + this.ngayvao.ToString("dd/MM/yyyy"));
            Console.WriteLine("Gioi Tinh: " + this.gioitinh);
            Console.WriteLine("CMND: " + this.cmdn);
            Console.WriteLine("Luong Co Ban: " + this.luongcoban);
        }
    }
}