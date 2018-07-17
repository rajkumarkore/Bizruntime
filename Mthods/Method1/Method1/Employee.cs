using System;

namespace Method1
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }

        public void SwipeIn()
        {

        }
        public virtual void GivePresentation()
        {
            Console.WriteLine("all employee give Presentation");
        }

    }

    public class Manager : Employee
    {
        public virtual void CreateProposal()
        {
            Console.WriteLine("i am developing the proposal");
        }
        public override void GivePresentation()
        {
            base.GivePresentation();
            Console.WriteLine("Manager is giving  Presentation");
        }
    }
    public class Developer : Employee
    {
        public void DevelopeCode()
        {

        }

        public override void GivePresentation()
        {
            Console.WriteLine("devloper is giving  Presentation");
        }
    }

    class Method1
    {
        static void Main(string[] args)
        {
            //Employee obj = new Employee();
            Developer obj = new Developer();
            //Manager obj = new Manager();
            obj.GivePresentation();
            Console.ReadLine();
        }
    }
}