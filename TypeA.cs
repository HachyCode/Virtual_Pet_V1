using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class TypeA : Medicine
    {
        //override properties
        public override int HappinesValue { get { return 0; } }
        public override int FoodValue { get { return 0; } }
        public override int HealthValue { get { return 100; } }
        public override int EnergyValue { get { return 0; } }
        public override int CleannessValue { get { return 0; } }
        public override int Cost { get { return 10; } }
    }
}
