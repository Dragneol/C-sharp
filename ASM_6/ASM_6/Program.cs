using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Medicine medicine = new Medicine { BatchNumber = 10, Code = "100", Date = "15-1-12654", ExpireDate = "212", Manufacturer = "123", Name = "name", Price = 1, Quantity = 1 };
            //medicine.info();

            string strInt = "24532";
            string strNull = null;
            string strWrongFrmt = "5.87";
            string strAboveRange = "98765432123456";
            int res;
            try
            {
                // int.Parse() - TEST
                res = int.Parse(strInt); // res = 24532
                //res = int.Parse(strNull); // System.ArgumentNullException
                //res = int.Parse(strWrongFrmt); // System.FormatException
                //res = int.Parse(strAboveRange); // System.OverflowException

                // Convert.ToInt32(string s) - TEST
                //res = Convert.ToInt32(strInt); // res = 24532
                //res = Convert.ToInt32(strNull); // res = 0
                //res = Convert.ToInt32(strWrongFrmt); // System.FormatException
                //res = Convert.ToInt32(strAboveRange); //System.OverflowException

                // int.TryParse(string s, out res) - Test
                bool isParsed;
                //isParsed = int.TryParse(strInt, out res); // isParsed = true, res = 24532
                //isParsed = int.TryParse(strNull, out res); // isParsed = false, res = 0
                isParsed = int.TryParse(strWrongFrmt, out res); // isParsed = false, res = 0
                //isParsed = int.TryParse(strAboveRange, out res); // isParsed = false, res = 0 

                Console.WriteLine($"{res} {isParsed}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Check this.\n" + e.Message);
            }
        }
    }
}
