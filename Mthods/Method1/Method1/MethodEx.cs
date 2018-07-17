using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Person
    {
        public string GetFullname(string Firstname, string Lastname)
        {
            return "full name {Firstname} {Lastname}";
        }
        class MethodEx
        {
            static void Main(string[] args)
            {
                Person person = new Person();
                var fullname = person.GetFullname("om", "sai");
                Console.WriteLine(fullname);

            }
        }
    }
}
