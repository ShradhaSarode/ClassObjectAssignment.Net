using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF.
 Accept the value of id, name & basic salary from constructor.
Calculate the employee gross salary  & display employee details using ToString() method
a.	HRA- 40% of basic salary
b.	TA – 20% of basic salary
c.	PF -12 % of basic salary
*/
namespace ClassObjectAssignment
{
    public class Employee
    {
        private static int nextId = 1;
        private int id;
        private string name;
        private double basicSalary;
        private double hra;
        private double ta;
        private double pf;

        public Employee(int id, string name, double basicSalary)
        {
            this.id = id;
            this.name = name;
            this.basicSalary = basicSalary;

            this.hra = 0.4 * basicSalary; // HRA is 40% of basic salary
            this.ta = 0.2 * basicSalary;  // TA is 20% of basic salary
            this.pf = 0.12 * basicSalary; // PF is 12% of basic salary
        }
        public double CalculateGrossSalary()
        {
            return basicSalary + hra + ta - pf;
        }
       
        public override string? ToString()
        {
            return $"id : {id} , Name: {name}  , Salary: {basicSalary} , " +
                $"HRA: {hra} , TA: {ta} , PF : {pf} , GrossSalary: {CalculateGrossSalary()}";
        }
    }
    public class Q1
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee(101, "Ritu", 45000);
            Employee emp1 = new Employee(102, "Nitu", 25000);
            Employee emp2 = new Employee(103, "Bitu", 35000);

            Console.WriteLine(emp);
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

           
        }
    }
}
