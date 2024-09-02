using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IHasMilk
    {
        public Cortado(int dis, Blend blend):base(dis, blend) {
            
        }
        public override string Strength()
        {
            return $"{base.Strength()} {Str.Medium.ToString()}"; 
        }

        public override int MlMilk()
        {
            return 40;
        }

        public override int Price()
        {
            return base.Price() + 5; 
        }
    }
}
