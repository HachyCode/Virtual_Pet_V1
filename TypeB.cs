using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class TypeB : Medicine
    {
        //override properties
        public override int HappinesValue { get { return 50; } }
        public override int FoodValue { get { return 50; } }
        public override int HealthValue { get { return 50; } }
        public override int EnergyValue { get { return 50; } }
        public override int CleannessValue { get { return 50; } }
        public override int Cost { get { return 50; } }
    }
}
