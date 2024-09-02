using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Coffee
    {
        private int _discount;
        private int dis;

        public Coffee(int dis, Blend blend)
        {
            Discount = dis;
            CoffeeBlend = blend;
        }

       

        public virtual int Price() => 20;
        public virtual string Strength() => "Strength: ";
        public virtual int MlMilk() => 0;
        public virtual int Discount
        {
            get => _discount; protected set
            {
                if (value > 5 || value < 0)
                {
                    throw new ArgumentException($"Discount may not be smaller than 0 or bigger than 5. You chose: {value}");
                }
                else
                {
                    _discount = value;
                }
            }
        }


        public Blend CoffeeBlend {  get; protected set; }
        public virtual MilkType Milk { get; set; }
    }

    public enum Str
    {
        Weak = 0,
        Medium = 1,
        Strong = 2,
    }

    public enum Blend
    {
        Bekele = 0,
        Gichathaini = 1,
        Aga = 2,
        kieni = 3,
        
    }

    public enum MilkType
    {
        Milk = 0,
        Skimmed = 1,
        Full = 2,
        Oat = 3,
        Soy = 4,
        None = 5,
    }
}
