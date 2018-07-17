using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ClsEmp  //interface dnt have any implemtn
    {
        void GetEmpData(); //and a class which contain abst fun is called inteface
        void DisplayEmpData();//inteface fun are pulic and abstract  by default
    }

    class ClsManager2 : ClsEmp //a inteface can be implementad by other class
    {
        int EmpId;
        string EName;
        double CA, Bonus;

        public void GetEmpData()
        {
            Console.WriteLine("enter manager details:");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.CA = Convert.ToDouble(Console.ReadLine());
            this.Bonus = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayEmpData()
        {
            Console.WriteLine("Manager Details are : ");
            Console.WriteLine("Manager Id is :" + this.EmpId);
            Console.WriteLine("CA is :" + this.CA);
            Console.WriteLine("Bonus  is :" + this.Bonus);
        }
     }
    class ClsInterface
    {
        static void Main(string[] args)
        {
            ClsManager2 obj1 = new ClsManager2();
            obj1.GetEmpData();
            obj1.DisplayEmpData();
            Console.ReadLine();
        }
    }
 }


/*
 
enter manager details:
1235
om
4521
2541
Manager Details are :
Manager Id is :1235
CA is :4521
Bonus  is :2541
 
*/




