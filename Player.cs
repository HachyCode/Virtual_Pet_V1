using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class Player
    {
        //Inctantiations
        public Inventory inventory = new Inventory(); //instantiating inventory class

        public List<Pet> pets = new List<Pet>();

        //methods
        public void AddPet()
        {
            Application.addingPet = true;
            bool addedPet = false;

            while (!addedPet)
            {
                Console.Clear();
                Console.WriteLine("Select pet type /n1:PolarBear /n2:Lion /n3:Dolphin");
                string type = Console.ReadLine();

                if (type == "Polar Bear" || type == "polar bear" || type == "polarbear" || type == "polarBear" || type == "Polar bear" || type == "Polarbear")
                {
                    type = "PolarBear";
                }
                else if (type == "lion" || type == "loin")
                {
                    type = "Lion";
                }
                else if (type == "dolphin" || type == "dolphine" || type == "dolfine")
                {
                    type = "Dolphin";
                }

                if (type == "PolarBear" || type == "Lion" || type == "Dolphin")
                {
                    Console.WriteLine("Enter pets name: ");
                    string name = Console.ReadLine();

                    pets.Add(new Pet(name, type));
                    addedPet = true;
                    Application.addingPet = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Try Again !!");
                }
            }
        }
    }
}

