using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace laba_2_s4
{
    public class Student
    {
        public string surname;
        public string name;
        public string profession;
        public string course;
        public float average;
        public int age;
        public string sex;
        public Work work;
        public Address adr;
        public Student(string surname, string name, string profession, string course, float average, int age, string sex, Address adr, Work work)
        {
            this.surname = surname;
            this.name = name;
            this.profession = profession;
            this.course = course;
            this.average = average;
            this.age = age;
            this.sex = sex;
            this.adr = adr;
            this.work = work;
        }
        public Student()
        {
            surname = "unknown";
            name = "unknown";
            profession = "unknown";
            average = 0;
        }
        public override string ToString()
        {
            return "Surname: " + surname + "; Name: " + name + "; Profession: " + profession + "; Course: " + course + "; Average: " + average + "; Age: " + age + "; Sex: " + sex + adr.ToString() + work.ToString();
        }
    }
}
