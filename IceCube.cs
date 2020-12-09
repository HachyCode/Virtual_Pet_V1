using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class IceCube : Toy
    {
        //override properties
        public override int HappinesValue { get { return 100; } }
        public override int Cost { get { return 5; } }
        public override int UseAmount { get { return 2; } }
        public int UseAmountLeft
        {
            get { return useAmountLeft; }
            set { useAmountLeft = value; }
        }

        //veriables
        private int useAmountLeft;

        //Constuructor
        public IceCube()
        {
            useAmountLeft = UseAmount;
        }

        
    }
}
