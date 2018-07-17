using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject  //namespace is logical container 
{
    public delegate void AddDelegate(int i, int j);//delegate having the invoke mtd internally
    public delegate string SayDelegate(string str);//delegate is use to call the reference of the method
    class Program
    {
        public void Addsum(int i ,int j) //here addsum methd
        {
            Console.WriteLine(i + j);
        }

        public static string Sayhello(string name)   //delegate holds to refernce  of methods
        {
            return "Om " + name;
        }
        static void Main(string[] args)
        {
            //here instatiate a class
            Program p = new Program();
            //p.Addsum(100, 20);
           
            AddDelegate ad = new AddDelegate(p.Addsum);
            //ad(100, 40); //local variable .

            ad.Invoke(100, 50);
            //here sayhello is static class so call that static class by name

            SayDelegate sd = new SayDelegate(Program.Sayhello);//static member dirctly call another staic block within the class.
            //string str = Program.Sayhello("Om sai");

            string str = sd.Invoke("sai");
            Console.WriteLine(str);
            Console.ReadLine();
           
        }
    }
}


//150
//om sai

//return type of shoult exectly mathch with parameter of delegate
//parameter of delegate shold match with same type
//in delegate method name nt using static

//static member dirctly call another staic block within the class.
//but outside the class prefix   with the class name like prgm















