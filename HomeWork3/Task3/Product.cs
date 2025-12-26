using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task3
{
    public class Product
    {
        public string Name { get; set; }   /* اسم محصول*/
        public double Price { get; set; }   /*قیمت محصول*/

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string GetProductDetail()   /*اطلاعات محصول*/ 
        {
            return $"Name: {Name}, Price: {Price}";
        }
    }
}
