using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace SampleBinarySerialization
{
    [Serializable]
    public class MyObject
    {
        public int n1 = 0;
        public int n2 = 0;
        public String str = null;
    }

    class Program
    {
        static void BinarySerialization()
        {            
            //string fileName = @"../../MyFile.bin";
            string fileName = @"../../MyFile.soap";
            MyObject obj = new MyObject();
            obj.n1 = 1;
            obj.n2 = 24;
            obj.str = "Some String";
            //IFormatter formatter = new BinaryFormatter();
            IFormatter formatter = new SoapFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            stream.Close();

        }
        static void BinaryDeSerialization()
        {
            //string fileName = @"../../MyFile.bin";
            string fileName = @"../../MyFile.soap";
            //IFormatter formatter = new BinaryFormatter();
            IFormatter formatter = new SoapFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            MyObject obj = (MyObject)formatter.Deserialize(stream);
            stream.Close();
            // Here's the proof.
            Console.WriteLine("n1: {0}", obj.n1);
            Console.WriteLine("n2: {0}", obj.n2);
            Console.WriteLine("str: {0}", obj.str);
        }
        static void Main(string[] args)
        {
            BinarySerialization();
            Console.WriteLine("Object is serialized, Press Enter to continue...");
            Console.ReadLine();
            BinaryDeSerialization();
        }
    }
}
