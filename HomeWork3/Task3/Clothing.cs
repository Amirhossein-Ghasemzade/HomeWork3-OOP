using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task3
{
    public class Clothing : Product, IDiscountable
    {
        public string Size { get; set; }
        public string Material { get; set; }

        public Clothing(string name, double price, string size, string material)
            :base(name, price)
        {
            Size = size;
            Material = material;
        }
        public override string GetProductDetail()
        {
            return $"Closing -> Name: {Name}, Price: {Price}, Size; {Size}, Material: {Material}";
        }
        public void ApplyDiscount(double percent)
        {
            Price = Price - (Price * percent / 100.0);
        }
    }
}
