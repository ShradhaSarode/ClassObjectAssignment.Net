using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*2.Create class Product.
  Add fields like id, name and price. 
  Create properties for each field. 
  Use object initializer syntax initialize the object. 
  Print product details using ToString()*/
namespace ClassObjectAssignment
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string? ToString()
        {
            return $"id : {Id} , Name: {Name}  , Salary: {Price}  ";
        }
    }
    public class Q2
    {
        static void Main(string[] args)
        {
            
            Product product = new Product(1001,"Laptop", 15999.99 );
            Product p1 = new Product(1002, "Motherboard", 999.99);
            Console.WriteLine(product);
            Console.WriteLine(p1);
        }
    }
}
