using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Studentt : Person
    {
        public Studentt(string name, int age, string address, string nationality, string studyLevel, string specializatipn, int gPA) : base(name,age,address,nationality)
        {
            StudyLevel = studyLevel;
            this.specializatipn = specializatipn;
            GPA = gPA;
        }

        public string StudyLevel { get; set; }
        public string specializatipn { get; set; }
        public int GPA { get; set; }



    }
}
