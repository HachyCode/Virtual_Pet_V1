using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class Medicine : I_Item
    {
        //Virtual properties
        public virtual int HappinesValue { get { return 0; } }
        public virtual int FoodValue { get { return 0; } }
        public virtual int HealthValue { get { return 0; } }
        public virtual int EnergyValue { get { return 0; } }
        public virtual int CleannessValue { get { return 0; } }
        public virtual int Cost { get { return 10; } }
    }
}
