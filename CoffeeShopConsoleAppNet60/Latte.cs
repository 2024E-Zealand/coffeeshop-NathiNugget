using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IHasMilk
    {
        public Latte(int dis, Blend blend) : base(dis, blend)
        {
        }

        public override int Price()
        {
            return base.Price() + 20;
        }

        public override int MlMilk()
        {
            return 200; 
        }
        public override string Strength()
        {
            return $"{base.Strength()} {Str.Weak}";
        }
    }
}
