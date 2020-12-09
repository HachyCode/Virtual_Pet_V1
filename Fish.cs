using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class Fish : Food
    {
        //override properties
        public override int Cost { get { return 5; } }
        public override int FoodValue { get { return 70; } }
        public override int HealthValue { get { return 20; } }
    }
}
