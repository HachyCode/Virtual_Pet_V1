using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class Vegetable : Food
    {
        //override properties
        public override int Cost { get { return 2; } }
        public override int FoodValue { get { return 50; } }
        public override int HealthValue { get { return 20; } }
        public override int HappinesValue { get { return -10; } }
    }
}
