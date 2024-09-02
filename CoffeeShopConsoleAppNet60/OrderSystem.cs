using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class OrderSystem
    {
       
        

        public OrderSystem() {
            Orders = new List<Order>();
            MenuCard = new List<Coffee>();
            Coffee bc = new BlackCoffee(2, Blend.Bekele);
            Coffee cor = new Cortado(3, Blend.Aga);
            Coffee fw = new FlateWhite(2, Blend.kieni);
            Coffee lt = new Latte(1, Blend.Gichathaini); 
            MenuCard.Add(bc);
            MenuCard.Add(cor);
            MenuCard.Add(fw);
            MenuCard.Add(lt);
        }
        public List<Order> Orders { get; set; }
        public List<Coffee> MenuCard { get; private set; }
    }
}
