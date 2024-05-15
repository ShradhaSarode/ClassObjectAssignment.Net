using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

/*3.Use above Product class, 
 * create Discount method & accept the discount percentage. 
 * Give discount to the price & Display actual price & discounted price*/
namespace ClassObjectAssignment
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Products(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string? ToString()
        {
            return $"id : {Id} , Name: {Name}  , Salary: {Price}  ";
        }
        public void ApplyDiscount(double discountPercentage)
        {
            double discountAmount = Price * (discountPercentage / 100);
            double discountPrice = Price - discountAmount;
            Console.WriteLine("Discounted Price:  "+discountPrice);
        }
    }
    public class Q3
    {
        public static void Main(string[] args)
        {
            Products p1 = new Products(1, "Mobile", 25000);
            Console.WriteLine(p1.ToString());

            double discountPercentage = 10;
            p1.ApplyDiscount(discountPercentage);
        }
       
    }
}
