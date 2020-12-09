using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    interface I_Pet
    {
        //Properties
        string Name { get; }

        int AmbientTemp { get; set; }

        int Happines { get; }

        int Food { get; }

        int Health { get; }

        int Energy { get; }

        int Cleanness { get; }
    }
}
