using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class Update
    {
        //Instantiation
        public static Display display = new Display();

        //run all methods
        public void UpdateMethod()
        {
            //Coins update
            CoinUpdate();

            //room temp update
            RoomTempUpdate();

            //pet statistics update
            PetUpdate();

            display.DisplayMethod();

        }

        //Update methods
        private void CoinUpdate()
        {
            Application.player.inventory.AddCoin(1); //puse 1 coin
        }

        private void RoomTempUpdate()
        {
            Application.player.pets[Application.PetNum].TempControl();
        }

        private void PetUpdate()
        {
            Application.player.pets[Application.PetNum].ControlHappines(-1);
            Application.player.pets[Application.PetNum].ControlFood(-1);
            Application.player.pets[Application.PetNum].ControlEnergy(-1);
            Application.player.pets[Application.PetNum].ControlCleanness(-1);

            if (Application.player.pets[Application.PetNum].Happines <= 20 || Application.player.pets[Application.PetNum].Food <= 20 || Application.player.pets[Application.PetNum].Energy <= 20 || Application.player.pets[Application.PetNum].Cleanness <= 20)
            {
                Application.player.pets[0].ControlHealth(-1);
            }

            if (Application.player.pets[Application.PetNum].CurrentTemp > Application.player.pets[Application.PetNum].AmbientTemp - 10 ^ Application.player.pets[Application.PetNum].CurrentTemp < Application.player.pets[Application.PetNum].AmbientTemp + 10)
            {
                Application.player.pets[0].ControlHealth(-5);//if diferent in current and ambient temp is more that 20. Helth will go down by -5
            }

            if (Application.player.pets[Application.PetNum].Happines == 0 && Application.player.pets[Application.PetNum].Food <= 0 && Application.player.pets[Application.PetNum].Energy <= 0 && Application.player.pets[Application.PetNum].Cleanness <= 0 && Application.player.pets[Application.PetNum].Health <= 0)
            {

            }
        }
    }
}
