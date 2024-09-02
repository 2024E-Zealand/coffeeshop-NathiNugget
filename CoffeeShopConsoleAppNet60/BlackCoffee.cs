using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int dis, Blend blend) : base(dis, blend)
        {
        }

        public override string Strength()
        {
            return $"{base.Strength()} {Str.Strong.ToString()}";
        }

        public override int MlMilk()
        {
            return base.MlMilk();
        }

        public override int Price()
        {
            return base.Price() + 18;
        }
    }
}
