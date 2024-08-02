using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Employee:Person
    {
        public Employee(string name, int age, string address, string nationality, int salary, string rank, string job):base(name,age,address,nationality)
        {
            Salary = salary;
            Rank = rank;
            Job = job;
        }

        public int Salary { get; set; }
        public string Rank { get; set; }
        public string Job { get; set; }
      
    }
}
