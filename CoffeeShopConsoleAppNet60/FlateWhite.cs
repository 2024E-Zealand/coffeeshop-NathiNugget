using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class FlateWhite : Coffee, IHasMilk
    {
        public FlateWhite(int dis, Blend blend) : base(dis, blend)
        {
        }

        public override int Price()
        {
            return base.Price() + 17;
        }

        public override int MlMilk()
        {
            return base.MlMilk() + 5;
        }

 
    }
}
