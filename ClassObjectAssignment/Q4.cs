using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*4.Create class Student, with roll no , name , percentage auto implemented properties. 
 * Use property initialize syntax to assign the values. 
 * Print the student details*/
namespace ClassObjectAssignment
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

        public Student(int rollNo, string name, double percentage)
        {
            RollNo = rollNo;
            this.Name = name;
            this.Percentage = percentage;
        }

        public override string? ToString()
        {
            return $"Roll no: {RollNo}, Name: {Name}, Percentage: {Percentage}";
        }
    }
    public class Q4
    {
        public static void Main(string[] args)
        {
            Student stud = new Student(101, "Shreya", 78.5);
            Console.WriteLine(stud);
        }
    }
}
