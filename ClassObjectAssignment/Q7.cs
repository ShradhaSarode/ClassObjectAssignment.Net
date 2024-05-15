using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*7.Create Student class with roll no, name, accept
 * 3 subjects marks from constructor. Calculate the total marks & percentage. 
 * Display student details using ToString()*/
namespace ClassObjectAssignment
{
    public class Student1
    {
        private int rollNo;
        private string name;
        private int subject1Marks;
        private int subject2Marks;
        private int subject3Marks;

        public Student1(int rollNo, string name, int subject1Marks, int subject2Marks, int subject3Marks)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.subject1Marks = subject1Marks;
            this.subject2Marks = subject2Marks;
            this.subject3Marks = subject3Marks;
        }
        public int CalculateTotalMarks()
        {
            return subject1Marks + subject2Marks + subject3Marks;
        }
        public double CalculatePercentage()
        {
            int totalMarks = CalculateTotalMarks();
            return (totalMarks / 3.0) * 100;
        }
        public override string? ToString()
        {
            return $"Roll No: {rollNo}, Name: {name}, Subject 1 Marks: {subject1Marks}, Subject 2 Marks: {subject2Marks}, Subject 3 Marks: {subject3Marks}, Total Marks: {CalculateTotalMarks()}, Percentage: {CalculatePercentage():F2}%";
        }
    }
    public class Q7
    {
        static void Main(string[] args)
        {
            Student1 student = new Student1(101, "Prashant", 80, 85, 90);
            Console.WriteLine(student.ToString());
        }
    }
}
