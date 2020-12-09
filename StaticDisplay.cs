using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class StaticDisplay : BoxDisplay
    {
        //run all methods
        public void SDisplay()
        {
            Console.Clear();
            Console.SetWindowSize(120, 40);
            Console.CursorVisible = false;

            TempInfoBox();
            ControledPetBox();
            OtherPetsBox();
            PetStatisticsBox();
            InventoryBox();
            KeysBox();

            TempInfoText();
            ControledPetText();
            OtherPetsText();
            PetStatisticsText();
            InventoryText();
            KeysText();
        }

        //methods to display static box information
        public void TempInfoText()
        {
            Console.SetCursorPosition(3, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Temp. Control");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("▓ Heater");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("▓ Off");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("▓ Cooler");

            for(int i = 1; i <= 21; i++)
            {
                Console.SetCursorPosition(6, 6 + i);
                Console.WriteLine("▓");
            }

            for(int i = 1; i <= 10; i++)
            {
                Console.SetCursorPosition(8, 6 + i);
                Console.WriteLine("+");
            }

            int plusTemp = 50;
            for (int i = 1; i <= 11; i++)
            {
                Console.SetCursorPosition(9, 6 + i);
                Console.WriteLine(plusTemp);
                plusTemp = plusTemp - 5;
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.SetCursorPosition(8, 17 + i);
                Console.WriteLine(plusTemp);
                plusTemp = plusTemp - 5;
            }


            Console.SetCursorPosition(3, 29);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Current Temp.");
            Console.SetCursorPosition(6, 30);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("40.00");

            Console.SetCursorPosition(3, 32);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ambient Temp.");
            Console.SetCursorPosition(6, 33);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("40.00");
        }

        public void ControledPetText()
        {
            Console.SetCursorPosition(28, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Controled Pet");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(21, 3);
            Console.WriteLine("Name : ");

            Console.SetCursorPosition(21, 4);
            Console.WriteLine("Type : ");
        }

        public void OtherPetsText()
        {
            Console.SetCursorPosition(28, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Controled Pet");

            int petY = 9;

            for(int i = 1; i <= Application.player.pets.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(21, petY + i); 
                petY++;
                Console.WriteLine("Name : ");

                Console.SetCursorPosition(21, petY + i);
                Console.WriteLine("Type : ");

                petY++;
            }
        }

        public void PetStatisticsText()
        {
            Console.SetCursorPosition(68, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Statistics");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(54, 3);
            Console.Write("Happiness :    %  ");

            Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");

            Console.SetCursorPosition(54, 5);
            Console.Write("Food :         %  ");

            Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");

            Console.SetCursorPosition(54, 7);
            Console.Write("Health :       %  ");

            Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");

            Console.SetCursorPosition(54, 9);
            Console.Write("Energy :       %  ");

            Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");

            Console.SetCursorPosition(54, 11);
            Console.Write("Cleanness :    %  ");

            Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
        }

        public void InventoryText()
        {
            Console.SetCursorPosition(60, 15);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inventory");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(54, 17);
            Console.WriteLine("Coin :");

            Console.SetCursorPosition(54, 19);
            Console.WriteLine("Vegetable :");
            Console.SetCursorPosition(54, 20);
            Console.WriteLine("Meat      :");
            Console.SetCursorPosition(54, 21);
            Console.WriteLine("Fish      :");

            Console.SetCursorPosition(54, 23);
            Console.Write("Ice Cube :        Use     /     ");
            Console.SetCursorPosition(54, 24);
            Console.Write("Ball     :        Use     /     ");
            Console.SetCursorPosition(54, 25);
            Console.Write("Pumpkin  :        Use     /     ");

            Console.SetCursorPosition(54, 27);
            Console.WriteLine("Type A :");
            Console.SetCursorPosition(54, 28);
            Console.WriteLine("Type B :");
            Console.SetCursorPosition(54, 29);
            Console.WriteLine("Type X :");

        }

        public void KeysText()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(100, 1);
            Console.WriteLine("Action Keys");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(95, 3);
            Console.WriteLine("esc : Exit");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(95, 5);
            Console.Write("Feed - Buy Food");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(95, 6);
            Console.WriteLine("A - 1 : Vegetable");
            Console.SetCursorPosition(95, 7);
            Console.WriteLine("B - 2 : Meat");
            Console.SetCursorPosition(95, 8);
            Console.WriteLine("C - 3 : Fish");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(95, 10);
            Console.WriteLine("Play - Buy Toy");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(95, 11);
            Console.WriteLine("D - 4 : Ice Cube");
            Console.SetCursorPosition(95, 12);
            Console.WriteLine("E - 5 : Ball");
            Console.SetCursorPosition(95, 13);
            Console.WriteLine("F - 6 : Pumpkin");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(95, 15);
            Console.WriteLine("Give - Buy Medicine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(95, 16);
            Console.WriteLine("G - 7 : Type A");
            Console.SetCursorPosition(95, 17);
            Console.WriteLine("H - 8 : Type B");
            Console.SetCursorPosition(95, 18);
            Console.WriteLine("I - 9 : Type C");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(95, 20);
            Console.WriteLine("Other");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(95, 21);
            Console.WriteLine("J : Put to bed");
            Console.SetCursorPosition(95, 22);
            Console.WriteLine("K : Bath");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(95, 24);
            Console.WriteLine("Temp Control");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(95, 25);
            Console.WriteLine("L : Heater");
            Console.SetCursorPosition(95, 26);
            Console.WriteLine("M : Off");
            Console.SetCursorPosition(95, 27);
            Console.WriteLine("N : Cooler");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(95, 29);
            Console.WriteLine("Other Pets");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(95, 30);
            Console.WriteLine("O : Change pet");
        }
    }
}
