using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Overriding
    {
        protected int EmpId;
        protected string EName;
        string EAddress;
        int EAge;

        public virtual void GetEmpData()
        {
            Console.WriteLine("Enter Emp Details:");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.EAddress = Console.ReadLine();
            this.EAge = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void DisplayEmpData()
        {
            Console.WriteLine("Emp Details are");
            Console.WriteLine("EmpId is :" +this.EmpId);
            Console.WriteLine("EName is : " + this.EName);
            Console.WriteLine("EAddress is : " + this.EAddress);
            Console.WriteLine("EAge is : " + this.EAge);
        }
    }
    class B : Overriding
    {
        double CA, Bonus;
        public override void GetEmpData()
        {
            Console.WriteLine("Enter Manager Details:");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.CA = Convert.ToDouble(Console.ReadLine());
            this.Bonus = Convert.ToInt32(Console.ReadLine());
        }
        public override void DisplayEmpData()
        {
            Console.WriteLine("Manager details are :");
            Console.WriteLine("Manager id is :" + this.EmpId);
            Console.WriteLine("Manager Name is :" + this.EName);
            Console.WriteLine("CA is : " + this.CA);
            Console.WriteLine("Bonus is :" + this.Bonus);
        }
    }
    class Functionovrriding
    {
        static void Main(string[] args)
        {
            Overriding o = new Overriding();
            o.GetEmpData();
            o.DisplayEmpData();
            Console.Read();
        }
    }
        }
   
