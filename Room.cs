using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class Room
    {
        //variables
        protected decimal currentTemp;
        public bool HeaterOn = false;
        public bool CoolerOn = false;
        
        //properties
        public decimal CurrentTemp { get { return currentTemp; } }

        //Methods
        public void TempControl()
        {
            if(HeaterOn)
            {
                currentTemp = currentTemp + 0.1m;
            }
            else if (CoolerOn)
            {
                currentTemp = currentTemp + -0.1m;
            }
            else
            {
                currentTemp = currentTemp + -0.01m;
            }
        }
    }
}
