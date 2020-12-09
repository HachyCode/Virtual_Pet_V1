using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class Toy : I_Item, I_Toy
    {
        //Virtual properties
        public virtual int HappinesValue { get { return 100; } }
        public virtual int Cost { get { return 10; } }
        public virtual int UseAmount { get { return 10; } }

        //Default properties
        public int HealthValue { get { return 0; } }
        public int FoodValue { get { return -10; } }
        public int EnergyValue { get { return -30; } }
        public int CleannessValue { get { return -20; } }
    }
}
