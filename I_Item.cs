using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    interface I_Item
    {
        //Properties
        int HappinesValue { get; }

        int FoodValue { get; }

        int HealthValue { get; }

        int EnergyValue { get; }

        int CleannessValue { get; }

        int Cost { get; }
    }
}
