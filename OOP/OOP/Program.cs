using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Employee
    {
        private int empID;
        private string empName;
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public String fullName
        {
            //get { return empName; }
            //set { empName = value; }

            get => empName;
            set => empName = value;
        }/// <summary>
        /// dau tien khi su dung cach initalize no se dung contructor mac dinh sau do moi gan property vao
        /// </summary>
        public Employee()
        {
            ID = 0;
            fullName = string.Empty;
        }
        public Employee(int id, string name)
        {
            ID = id;
            fullName = name;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Employee {ID} have name {fullName}");
        }
    }
    class Manager : Employee
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Manager()
        {

        }

        public Manager(int id, string name, int age):base(id, name)
        {
            this.Age = age;
        }

        public  override void Print()
        {
            base.Print();
            Console.WriteLine($"Age {age}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Employee e1 = new Employee(1, "tom");
            e1.Print();

            //this is the same with a way to creat new Obj above
            //var e1 = new Employee(1, "tom");
            //e1.Print();
            #endregion


            Manager e2 = new Manager { ID = 2, fullName = "jerry" , Age = 15};            
            e2.Print();

            Class1 ca = new Class1();
            ca.display();
            ca.print();
        }
    }
}
