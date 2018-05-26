using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    static class Menu
    {
        public static string[] options = new string[] {
        "Xem danh sach sinh vien",
        "Them sinh vien",
        "Tim sinh vien",
        "Cap nhat thong tin sinh vien"
        };
        public static void PrintMenu()
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i}-{options[i]}");
            }
        }
    }
    class ListSinhVien
    {
        public static void AddSinhVien(List<SinhVien> list)
        {
            bool c;
            string maSV;
            do
            {
                maSV = readString("Ma sinh vien: ");
                c = FindByCode(list, maSV) == null;
                if (!c)
                {
                    System.Console.WriteLine("Ma sinh vien trung, nhap ma sinh vien khac");
                }
            } while (!c);
            string hoTen = readString("Ho ten: ");
            DateTime ngaySinh = readDateTime("Ngay sinh (dd/MM/yyyy): ");
            string diaChi = readString("Dia chi: ");
            string dienThoai = readString("So dien thoai: ");
            list.Add(new SinhVien(maSV, hoTen, ngaySinh, diaChi, dienThoai));
        }
        public static void ModifySinhVien(List<SinhVien> list)
        {
            SinhVien sv;
            string maSV = readString("Nhap ma sinh vien can chinh sua thong tin: ");
            sv = FindByCode(list, maSV);
            if (sv == null)
            {
                System.Console.WriteLine($"Khong tim thay sinh vien {maSV} trong he thong!");
            }
            else
            {
                sv.FullName = readString("Ho ten: ");
                sv.BirthDate = readDateTime("Ngay sinh (dd/MM/yyyy): ");
                sv.Address = readString("Dia chi: ");
                sv.Phone = readString("So dien thoai: ");
                System.Console.WriteLine("Cap nhat thanh cong");
            }
        }
        public static void FindSinhVien(List<SinhVien> list)
        {
            Console.WriteLine("find by student code : ");
            string msSV = Console.ReadLine();
            SinhVien sv = FindByCode(list, msSV);
            if (sv != null) sv.XemThongTin();
            else Console.WriteLine("Not found");
        }
        public static void ShowList(List<SinhVien> list)
        {
            if (list.Count.Equals(0))
            {
                Console.WriteLine("Empty List");
            }
            else
            {
                foreach (SinhVien sv in list)
                {
                    sv.XemThongTin();
                }
            }
        }
        private static string readString(string msg)
        {
            System.Console.Write(msg);
            return Console.ReadLine();
        }
        private static SinhVien FindByCode(List<SinhVien> list, string msSV)
        {
            foreach (SinhVien sv in list)
            {
                if (sv.StudentCode.Equals(msSV))
                {
                    return sv;
                }
            }
            return null;
        }
        private static DateTime readDateTime(string msg)
        {
            bool c = false;
            DateTime datetime = default(DateTime);
            do
            {
                try
                {
                    datetime = DateTime.ParseExact(readString(msg), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    c = true;
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("Date Format unacceptable");
                }
            } while (!c);
            return datetime;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
            bool choosen = false;
            List<SinhVien> list = new List<SinhVien>();
            #region sample new SinhVien
            SinhVien sv = new SinhVien
            {
                StudentCode = "01",
                FullName = "Hoang Duong",
                BirthDate = new DateTime(1998, 2, 16),
                Address = "54/4A4 TCH 10",
                Phone = "01674484419"
            };
            list.Add(sv);
            #endregion       
            do
            {
                Console.WriteLine("--WORKSHOP OOP IN C#--");
                Menu.PrintMenu();
                Console.WriteLine("Others for exit");
                choosen = int.TryParse(Console.ReadLine(), out choose);
                if (!choosen)
                {
                    Console.WriteLine("\nInput not acceptable\n");
                }
                switch (choose)
                {
                    case 0:
                        ListSinhVien.ShowList(list);
                        break;
                    case 1:
                        ListSinhVien.AddSinhVien(list);
                        break;
                    case 2:
                        ListSinhVien.FindSinhVien(list);
                        break;
                    case 3: break;
                }
            } while (choose >= 0 && choose < Menu.options.Length);
        }
    }
}
