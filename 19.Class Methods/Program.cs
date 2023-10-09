using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Class_Methods
{
    internal class Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aWeight, string aName, int aAge)
        {
            this.weight=aWeight;
            this.name=aName;
            this.age=aAge;
        }
        public bool IsObesse()
        {
            if (weight > 60) 
            { 
             return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            Student student1 = new Student(50, "Dineo", 17);
            Student student2 = new Student(67, "Dinah", 10);

            Console.WriteLine(student1.IsObesse());
            Console.WriteLine(student2.IsObesse());

            Console.Read();
        }
    }
}
