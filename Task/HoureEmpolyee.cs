using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class HoureEmpolyee : Employee
    {
        public HoureEmpolyee(string name, int age, string address, string nationality, int salary, string rank, string job, int workingHours, int hourRate) : base(name, age, address, nationality, salary, rank, job)
    {
            WorkingHours = workingHours;
            HourRate = hourRate;
        }

    public int WorkingHours { get; set; }
    public int HourRate { get; set; }



    }
}
