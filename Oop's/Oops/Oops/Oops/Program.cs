using System;

namespace Oops
{
    class ClsEmployee
    {
        int EmpId;
        string EName;
        string EAddress;
        int Eage;

        public void GetData()
        {
            Console.WriteLine("enter Details:");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.EAddress = Console.ReadLine();
            this.Eage = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayData()
        {
            Console.WriteLine("employee details");
            Console.WriteLine("EmpId is:" + this.EmpId);
            Console.WriteLine("EName is:" + this.EName);
            Console.WriteLine("EAddress is:" + this.EAddress);
            Console.WriteLine("EAge is : " + this.Eage);
        }
      }
    class ClsEncapsulate
    {
        static void Main(string[] args)
        {
            ClsEmployee obj1 = new ClsEmployee();
            obj1.GetData();
            obj1.DisplayData();
            Console.Read();
        }
    }
}

