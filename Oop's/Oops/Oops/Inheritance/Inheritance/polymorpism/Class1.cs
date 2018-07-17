using System;

namespace Inheritance
{
    class Class1
    {
        int Bcode;
        string BName;
        string BAddress;

        public void GetBranchData()
        {
            Console.WriteLine("enter branch details :");
            this.Bcode = Convert.ToInt32(Console.ReadLine());
            this.BName = Console.ReadLine();
            this.BAddress = Console.ReadLine();
        }
        public void DisplayBranchData()
        {
            Console.WriteLine("Branch details are :");
            Console.WriteLine("branch code is :" + this.Bcode);
            Console.WriteLine("branch name is : " + this.BName);
            Console.WriteLine("branch address is : " + this.BAddress);
        }
        }
    class ClsEmp1 : Class1
    {
        int EmpId;
        string EName;
        string EAddress;
        int EAge;

        public void GetEmpData()
        {
            Console.WriteLine("enter emp details :");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.EAddress = Console.ReadLine();
            this.EAge = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayEmpData()
        {
            Console.WriteLine("Emp details are: ");
            Console.WriteLine("EmpId is :" + this.EmpId);
            Console.WriteLine("EName is :" + this.EName);
            Console.WriteLine("EAddress is :" + this.EAddress);
            Console.WriteLine("Eage is : " + this.EAge);
        }
    }
    class ClsInheritance
    {
        static void Main(string[] args)
        {
            ClsEmp1 obj1 = new ClsEmp1();
            obj1.GetBranchData();
            obj1.GetEmpData();
            obj1.DisplayBranchData();
            obj1.DisplayEmpData();
            Console.Read();
        }
        }
    }


    
