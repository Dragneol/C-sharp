using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class SinhVien
    {
        private string mMaSV;

        public string StudentCode
        {
            get { return mMaSV; }
            set { mMaSV = value; }
        }
        private string HoTen;

        public string FullName
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        private DateTime NgaySinh;

        public DateTime BirthDate
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }

        private string DiaChi;

        public string Address
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }

        private string DienThoai;

        public string Phone
        {
            get { return DienThoai; }
            set { DienThoai = value; }
        }

        public SinhVien()
        {

        }

        /// <summary>
        /// constructor with param
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        public SinhVien(string code, string name, DateTime date, string address, string phone)
        {
            mMaSV = code;
            HoTen = name;
            NgaySinh = date;
            DiaChi = address;
            DienThoai = phone;
        }

        public void XemThongTin()
        {
            Console.WriteLine($"{StudentCode}-{FullName}-{BirthDate.ToShortDateString()}-{Address}-{Phone}");
        }
    }
}
