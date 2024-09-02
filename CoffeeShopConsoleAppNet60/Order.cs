using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Order
    {
        public Order(int orderID, string baristaName, string customerName, int tableID)
        {
            OrderID = orderID;
            BaristaName = baristaName;
            CustomerName = customerName;
            TableID = tableID;
            CoffeesInOrder = new List<Coffee>(); 
        }

        public int OrderID { get; set; }
        public string BaristaName { get; set; }
        public string CustomerName { get; set; }
        public int TableID { get; set; }
        public List<Coffee> CoffeesInOrder { get; set; }

        public int TotalPriceOfOrder()
        {
            return (int) CoffeesInOrder.Sum(x => x.Price()); 
        }

        public int CountOfItems()
        {
            return CoffeesInOrder.Count(); 
        }

        public int TotalDiscountOfItems() {
            return CoffeesInOrder.Sum(x => x.Discount); 
        }
    }
}
