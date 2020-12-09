using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class TypeX : Medicine
    {
        //override properties
        public override int HappinesValue { get { return -100; } }
        public override int FoodValue { get { return -100; } }
        public override int HealthValue { get { return -100; } }
        public override int EnergyValue { get { return -100; } }
        public override int CleannessValue { get { return -100; } }
        public override int Cost { get { return 1; } }
    }
}
