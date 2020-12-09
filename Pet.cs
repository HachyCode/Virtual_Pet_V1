using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    public enum PetType //Enum
    {
        PolarBear,
        Lion,
        Dolphin
    }

    class Pet : Room, I_Pet
    {
        //Variables and properties
        public PetType petType;

        private string name;
        public string Name { get { return name; } }

        public int AmbientTemp { get; set; }

        //statistic properties
        private int happines = 80;
        public int Happines { get { return happines; } }

        private int food = 80;
        public int Food { get { return food; } }

        private int health = 80;
        public int Health { get { return health; } }

        private int energy = 80;
        public int Energy { get { return energy; } }

        private int cleanness = 80;
        public int Cleanness { get { return cleanness; } }

        //Constuctor
        public Pet(string _name, string _type)
        {
            if (_type == "PolarBear")
            {
                petType = PetType.PolarBear;
                AmbientTemp = -20;
                currentTemp = -15;
                name = _name;
            }
            else if (_type == "Lion")
            {
                petType = PetType.Lion;
                AmbientTemp = 40;
                currentTemp = 35;
                name = _name;
            }
            else if (_type == "Dolphin")
            {
                petType = PetType.Dolphin;
                AmbientTemp = 20;
                currentTemp = 15;
                name = _name;
            }
            else
            {
                Console.WriteLine("ID10T");
            }
        }

        //Method statistic controls
        public void ControlHappines(int value)
        {
            if(Happines >= 0)
            {
                happines = happines + value;
            }

            if(Happines > 100)
            {
                happines = 101; //its display then update happens, update removes -1 there for it will be displayed as 100
            }
            else if (Happines < 0)
            {
                happines = 0;
            }
        }
        public void ControlFood(int value)
        {
            if (Food >= 0)
            {
                food = food + value;
            } 
            
            if (Food > 100)
            {
                food = 101;
            }
            else if (Food < 0)
            {
                food = 0;
            }
        }
        public void ControlEnergy(int value)
        {
            if (Energy >= 0)
            {
                energy = energy + value;
            }

            if (Energy > 100)
            {
                energy = 101;
            }
            else if (Energy < 0)
            {
                energy = 0;
            }
        }
        public void ControlHealth(int value)
        {
            if (Health >= 0)
            {
                health = health + value;
            }

            if (Health > 100)
            {
                health = 100;
            }
            else if (Health < 0)
            {
                health = 0;
            }
        }
        public void ControlCleanness(int value)
        {
            if (Cleanness >= 0)
            {
                cleanness = cleanness + value;
            }

            if (Cleanness > 100)
            {
                cleanness = 101;
            }
            else if (Cleanness < 0)
            {
                cleanness = 0;
            }
        } 
    }
}
