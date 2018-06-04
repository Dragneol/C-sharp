using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization;
using System.Collections;
using System.IO;

namespace SampleSoapSerialization
{
    class Program
    {
        static void SoapSerialize()
        {
            Hashtable addresses = new Hashtable();
            addresses.Add("Jeff", "123 Main Street, Redmond, WA 98052");
            addresses.Add("Fred", "987 Pine Road, Phila., PA 19116");
            addresses.Add("Mary", "PO Box 112233, Palo Alto, CA 94301");

            FileStream fs = new FileStream("DataFile.soap", FileMode.Create);

          
            SoapFormatter formatter = new SoapFormatter();
            try
            {
                formatter.Serialize(fs, addresses);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }


        static void SoapDeserialize()
        {
           
            Hashtable addresses = null;

            FileStream fs = new FileStream("DataFile.soap", FileMode.Open);
            try
            {
                SoapFormatter formatter = new SoapFormatter();               
                addresses = (Hashtable)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

       
            foreach (DictionaryEntry de in addresses)
            {
                Console.WriteLine("{0} lives at {1}.", de.Key, de.Value);
            }
        }

        static void Main(string[] args)
        {
            SoapSerialize();
            Console.WriteLine("Object is serialized, Press Enter to continue...");
            Console.ReadLine();
            SoapDeserialize();
        }
    }
}
