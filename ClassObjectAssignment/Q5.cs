using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.Use above Employee class, 
 * create a static field to auto increment the employee id & 
 * create static method to display the total object count.*/
namespace ClassObjectAssignment
{
    public class Employees
    {
        private static int nextId = 1;

        private const double PT = 200;//Q6

        private int id;
        private string name;
        private double basicSalary;
        private double hra;
        private double ta;
        private double pf;

        public Employees( string name, double basicSalary)
        {
            this.id = nextId++;
            this.name = name;
            this.basicSalary = basicSalary;
            this.hra = 0.4 * basicSalary;
            this.ta = 0.2 * basicSalary;
            this.pf = 0.12 * basicSalary;

        }
        public double CalculateGrossSalary()
        {
            double grossSalary = basicSalary + hra + ta - pf - PT;
            return grossSalary < 0 ? 0 : grossSalary; // Ensure gross salary is non-negative
        }
        public static void DisplayTotalEmpCount()
        {
            Console.WriteLine($"Total Emp Count: {nextId-1}");
        }
        public override string? ToString()
        {
            return $"id : {id} , Name: {name}  , Salary: {basicSalary}, " +
                $"HRA: {hra:C}, TA: {ta:C}, PF: {pf:C}, Gross Salary: {CalculateGrossSalary():C} ";
        }
    }
    public class Q5
    {
        public static void Main(string[] args)
        {
            Employees emp = new Employees( "Ritu", 45000);
            Employees emp1 = new Employees("Nitu", 25000);
            Employees emp2 = new Employees("Bitu", 35000);

            Console.WriteLine(emp);
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            Employees.DisplayTotalEmpCount();
        }
    }
}
