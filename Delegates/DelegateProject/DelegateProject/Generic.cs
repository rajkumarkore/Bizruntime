using System;
using System.Collections.Generic;

namespace DelegateProject
{
    delegate bool IsPromotable(Employee emp1);
    class Generic
    {
     public   static void Main()
        {
            List<Employee> e = new List<Employee>();

            e.Add(new Employee() { ID = 101, Name = "om", salary = 8000, Experience = 8 });
            e.Add(new Employee() { ID = 101, Name = "omsai", salary = 8100, Experience = 9 });
            e.Add(new Employee() { ID = 101, Name = "omram", salary = 80400, Experience = 7 });

            IsPromotable p = new IsPromotable(Promote);

            Employee.PromoteEmployee(e, p);
        }
        
        public static  bool  Promote(Employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
            Console.ReadLine();
        }

        }   

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeesList, IsPromotable IsEligibleToPromote)
        {
            foreach(Employee e in employeesList)
            {
                if(IsEligibleToPromote(e))
                {
                    Console.WriteLine(e.Name + " promoted");
                }
                Console.ReadLine();
            }
        }
    }
}
