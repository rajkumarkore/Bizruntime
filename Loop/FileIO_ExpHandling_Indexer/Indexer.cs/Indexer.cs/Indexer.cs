using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Emp
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }

    }

    class Dept
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        Emp[] EmpList;

        public Dept()
        {
            DeptId = 10;
            DeptName = "Sales";
            EmpList = new Emp[3]
            {
                new Emp { Id = 101, EmpName = "A", Salary = 23455},
                new Emp { Id = 102, EmpName = "b", Salary = 25455},
                new Emp { Id = 103, EmpName = "c", Salary = 23555},
            };
        }

        public Emp GetEmp(int id)
        {
            foreach (Emp emp in EmpList)
            {
                if (id == emp.Id)
                    return emp;
            }
            return null;
        }

        public Emp GetEmp(string name)
        {
            foreach (Emp emp in EmpList)
            {
                if (name == emp.EmpName)
                    return emp;
            }
            return null;
        }

        public Emp this[int id]
        {
            get
            {
                foreach (Emp emp in EmpList)
                {
                    if (id == emp.Id)
                        return emp;
                }
                return null;
            }

        }

        public Emp this[string name]
        {
            get
            {
                foreach (Emp emp in EmpList)
                {
                    if (name == emp.EmpName)
                        return emp;
                }
                return null;
            }

        }
    } 
    class Indexer
    {
         static void Main(string[] args)
        {
            Dept dept = new Dept();
            Console.WriteLine(dept[101].EmpName);
            Console.WriteLine(dept["c"].Id);
        }
    }
}


/*
 A
103
 */
