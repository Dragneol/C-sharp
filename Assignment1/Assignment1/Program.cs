using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            bool dup;
            string code;
            do
            {
                code = readString("Studen Code : ");
                dup = FindByCode(list, code) == null;
                if (!dup)
                {
                    System.Console.WriteLine("Dupplicate Code. Retype!");
                }
            } while (!dup);
            string name = readString("Full Name : ");
            DateTime date = readDateTime("Date of Birth (dd/MM/yyyy): ");
            string address = readString("Address : ");
            string phone = readPhone("Phone : ");
            list.Add(new SinhVien(code, name, date, address, phone));
        }
        public static void ModifySinhVien(List<SinhVien> list)
        {
            SinhVien sv;
            string code = readString("Code of modified Student : ");
            sv = FindByCode(list, code);
            if (sv == null)
            {
                System.Console.WriteLine($"{code} not found!");
            }
            else
            {
                sv.FullName = readString("Full Name : ");
                sv.BirthDate = readDateTime("Date of Birth (dd/MM/yyyy): ");
                sv.Address = readString("Address : ");
                sv.Phone = readPhone("Phone : ");
                Console.WriteLine("Updated");
            }
        }
        public static void FindSinhVien(List<SinhVien> list)
        {
            string msSV = readString("Found for Code : ");
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
            Console.Write(msg);
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
        private static string readPhone(string msg)
        {
            do
            {
                Console.Write(msg);
                string phone = Console.ReadLine();
                Regex phoneCultureRegex = new Regex(@"(09|01[2|6|8|9])+([0-9]{8})\b");
                if (!phoneCultureRegex.IsMatch(phone))
                {
                    Console.WriteLine("Wrong VN phone format");
                }
                else return phone;
            } while (true);
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
                    case 3:
                        ListSinhVien.ModifySinhVien(list);
                        break;
                }
            } while (choose >= 0 && choose < Menu.options.Length);
        }
    }
}
