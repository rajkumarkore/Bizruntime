using System;

namespace Inheritance
{
    class ClsBranch1
    {
        int Bcode;
        string BName;
        string BAddress;

        public void GetBData()
        {
            Console.WriteLine("Enter branch Details: ");
            this.Bcode = Convert.ToInt32(Console.ReadLine());
            this.BName = Console.ReadLine();
            this.BAddress = Console.ReadLine();
        }
        public void DisplayBData()
        {
            Console.WriteLine("branch detail are");
            Console.WriteLine("Branch code is : " + this.Bcode);
            Console.WriteLine("Branch name is :" + this.BName);
            Console.WriteLine("Branch address is " + this.BAddress);
        }
    }
    interface ClsEmployee9
    {
        void GetEmpData();
        void DisplayEmpDat();
    }
}
    class ClaManager2 : ClsBranch1, ClsEmployee9
    {
        int EmpId;
        string EName;
        double CA, Bonus;

        public void GetEmpData()
        {
            Console.WriteLine("Enter Manager Details : ");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.CA = Convert.ToDouble(Console.ReadLine());
            this.Bonus = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayEmpData()
        {
            Console.WriteLine("manager id is :" + this.EmpId);
            Console.WriteLine("manager name is : " + this.EName);
            Console.WriteLine("CA is :" + this.CA);
            Console.WriteLine("Bonus is : " + this.Bonus);
        }
    }
    class ClsMultipleInheritnce
    {
        static void Main(string[] args)
        {
            ClaManager2 obj1 = new ClaManager2();
            obj1.GetBData();
            obj1.GetEmpData();
            obj1.DisplayBData();
            obj1.DisplayEmpData();

            Console.Read();

        }
    }
}
