using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class Ball : Toy //Inherits toy class
    {
        //override properties
        public override int HappinesValue { get { return 100; } }
        public override int Cost { get { return 20; } }
        public override int UseAmount { get { return 10; } }

        public int UseAmountLeft
        {
            get { return useAmountLeft; }
            set { useAmountLeft = value; }
        }

        //veriables
        private int useAmountLeft;

        //Constuructor
        public Ball()
        {
            useAmountLeft = UseAmount;
        }
    }
}
