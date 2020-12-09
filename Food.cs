using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class Food : I_Item
    {
        //Virtual properties
        public virtual int Cost { get { return 10; } }
        public virtual int FoodValue { get { return 100; } }
        public virtual int HealthValue { get { return 10; } }
        public virtual int HappinesValue { get { return 20; } }

        //Default properties
        public int EnergyValue { get { return 0; } }
        public int CleannessValue { get { return -40; } }
    }
}
