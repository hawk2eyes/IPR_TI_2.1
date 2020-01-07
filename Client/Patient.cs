using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Patient
    {
        public string name { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public string gender { get; set; }
        public int maxheartbeat { get; set; }
        public Patient(string name, int age, int weight, string gender)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.gender = gender;
            this.maxheartbeat = calculateHeartrate();
        }
        public int calculateHeartrate()
        {
            int tempHeartRate;
            if (age < 25 && age >= 15)
            {
                tempHeartRate = 210;
            }
            else if (age < 35 && age >= 25)
            {
                tempHeartRate = 200;
            }
            else if (age < 40 && age >= 35)
            {
                tempHeartRate = 190;
            }
            else if (age < 45 && age >= 40)
            {
                tempHeartRate = 180;
            }
            else if (age < 50 && age >= 45)
            {
                tempHeartRate = 170;
            }
            else if (age < 55 && age >= 50)
            {
                tempHeartRate = 160;
            }
            else if (age < 60 && age >= 55)
            {
                tempHeartRate = 150;
            }
            else tempHeartRate = 0;

            return tempHeartRate;
        }
    }
}
