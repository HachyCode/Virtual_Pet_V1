using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VirtualPetV1
{
    class Application : Update
    {
        //Instantiation
        public static Player player = new Player();
        public static StaticDisplay sdisplay = new StaticDisplay();

        //Variables
        public static bool end = false;
        public static bool addingPet = false;
        public static bool Updatating = false;

        //Properties
        public static int PetNum { get; set; }

        //Constructor
        public Application()
        {
            Task executing = new Task(() => Execute()); //New task thread for updateing and displaying.
            executing.Start();
        }

        //Methods
        public void Run()
        {
            KeyControls controls = new KeyControls(); //Instantiation of controls
            controls.Run();
        }

        private void Execute()
        {
            //Adds a pet
            player.AddPet();
            sdisplay.SDisplay();

            //Add iteams for the start of the game
            player.inventory.AddItem("Vegetable");
            player.inventory.AddItem("Meat");
            player.inventory.AddItem("Fish");

            player.inventory.AddItem("IceCube");
            player.inventory.AddItem("Ball");
            player.inventory.AddItem("Pumpkin");

            player.inventory.AddItem("TypeA");
            player.inventory.AddItem("TypeB");
            player.inventory.AddItem("TypeX");

            //update method
            while (!end)
            {
                Thread.Sleep(1000); //waits 1 sec

                while (addingPet)
                {
                    Thread.Sleep(1000);
                }

                Updatating = true;
                UpdateMethod();
                Updatating = false;
            }
        }
    }
}
