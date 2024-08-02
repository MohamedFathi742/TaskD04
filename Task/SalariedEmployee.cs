using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class SalariedEmployee:Employee
    {
        public SalariedEmployee(string name, int age, string address, string nationality, int salary, string rank, string job, int bonus, int deduction) : base(name, age, address, nationality, salary, rank, job)
        {
            Bonus = bonus;
            Deduction = deduction;
        }

        public int Bonus { get; set; }
        public int Deduction { get; set; }


    }
}
