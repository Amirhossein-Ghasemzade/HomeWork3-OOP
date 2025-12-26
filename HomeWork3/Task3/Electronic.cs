using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task3
{
    public class Electronic : Product, IDiscountable
    {
        public int WarrantyPeriod { get; set; }      /*مدت گارانتی*/

        public Electronic(string name, double price, int warrantyperiod)
            : base(name, price)
        {
            WarrantyPeriod = warrantyperiod;
        }

        public override string GetProductDetail()
        {
            return $"Electronic -> Name: {Name}. Price: {Price}, Warrantyperiod:{WarrantyPeriod} months";
        }

        public void ApplyDiscount(double percent)       /* اعمال تخفیف*/
        {
            Price = Price - (Price * percent / 100.0);   /*کم کردن تخفیف از قیمت*/ 
        }
    }
}
