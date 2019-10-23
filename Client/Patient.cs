using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Patient
    {
        public Patient(string name, int age, int weight, string gender)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.gender = gender;
        }

        public string name { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public string gender { get; set; }



    }
}
