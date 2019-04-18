using System;

namespace Operators
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }
        public Product(string name, int qunatity, double price)
        {
            this.Name = name;
            this.Quantity = qunatity;
            this.Price = price;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name} || Quantity: {Quantity} || Price: {Price}");
        }
        public static Product operator + (Product p1, Product p2)
        {
            var quantity= p1.Quantity > p2.Quantity? p1.Quantity : p2.Quantity; ;
            return new Product($"{p1.Name} + {p2.Name}", quantity, p1.Price + p2.Price);
           
        }
        public static Product operator -(Product p1, Product p2)
        {
            Product product = new Product();
            product.Name = $"{p1.Name} - {p2.Name}";
            if (p1.Quantity > p2.Quantity)
            {
                product.Quantity = p1.Quantity;
            }
            else
            {
                product.Quantity = p2.Quantity;
            }
            product.Price = p1.Price - p2.Price;
            return product;
        }

        public static Product operator /(Product p1, Product p2)
        {
            Product product = new Product();
            product.Name = $"{p1.Name} / {p2.Name}";
            if (p1.Quantity > p2.Quantity)
            {
                product.Quantity = p1.Quantity;
            }
            else
            {
                product.Quantity = p2.Quantity;
            }
            product.Price = p1.Price / p2.Price;
            return product;
        }
        public static Product operator *(Product p1, Product p2)
        {
            Product product = new Product();
            product.Name = $"{p1.Name} * {p2.Name}";
            if (p1.Quantity > p2.Quantity)
            {
                product.Quantity = p1.Quantity;
            }
            else
            {
                product.Quantity = p2.Quantity;
            }
            product.Price = p1.Price * p2.Price;
            return product;
        }
        public static Product operator %(Product p1, Product p2)
        {
            Product product = new Product();
            product.Name = $"{p1.Name} % {p2.Name}";
            if (p1.Quantity > p2.Quantity)
            {
                product.Quantity = p1.Quantity;
            }
            else
            {
                product.Quantity = p2.Quantity;
            }
            product.Price = p1.Price % p2.Price;
            return product;
        }
        public static Product operator ++(Product p1)
        {
            Product product = new Product();
            product.Name = $"{p1.Name}++";
            product.Quantity = p1.Quantity ++;
            
            product.Price = p1.Price ++;
            return product;
        }

        public static Product operator --(Product p1)
        {
            Product product = new Product();
            product.Name = $"{p1.Name}--";
            product.Quantity = p1.Quantity--;

            product.Price = p1.Price--;
            return product;
        }
        public static bool operator !(Product p1)
        {
            return p1.Quantity == 0;
        }

        public static Product operator +( Product p1, int a)
        {
            return new Product($"{p1.Name} + {a}", p1.Quantity+a, p1.Price);
        }

        public static bool operator ==(Product p1, Product p2)
        {
            return p1.Name == p2.Name && p1.Price == p2.Price;
            
        }
        public static bool operator !=(Product p1, Product p2)
        {
            return !(p1 == p2);
           
        }
        
        public static bool operator &(Product p1, Product p2)
        {
            return p1.Price > 0 && p2.Price > 0;
        }

        public static bool operator | (Product p1, Product p2)
        {
            return p1.Price > 0 || p2.Price > 0;
        }

        public static bool operator ^(Product p1, Product p2)
        {
            return p1.Price > 0 ^ p2.Price > 0;
        }
    }
}
