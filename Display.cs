using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class Display
    {
        //run all methods
        public void DisplayMethod()
        {
            TempInfo();
            ControledPet();
            OtherPets();
            PetStatistics();
            Inventory();
            Keys();
        }

        //methods to display updated information
        public void TempInfo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(6, 30);
            Console.WriteLine("      ");
            Console.SetCursorPosition(6, 30);
            Console.WriteLine(Application.player.pets[Application.PetNum].CurrentTemp);
            Console.SetCursorPosition(6, 33);
            Console.WriteLine("      ");
            Console.SetCursorPosition(6, 33);
            Console.WriteLine(Application.player.pets[Application.PetNum].AmbientTemp);

            Console.SetCursorPosition(5, 3);
            Console.WriteLine("▓");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("▓");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("▓");

            if (Application.player.pets[Application.PetNum].HeaterOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("▓");
            }

            else if (Application.player.pets[Application.PetNum].CoolerOn)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(5, 5);
                Console.WriteLine("▓");
            }

            else if (!Application.player.pets[Application.PetNum].CoolerOn && !Application.player.pets[Application.PetNum].HeaterOn)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(5, 4);
                Console.WriteLine("▓");
            }

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i <= 21; i++)
            {
                Console.SetCursorPosition(6, 6 + i);
                Console.WriteLine("▓");
            }

            if (Application.player.pets[Application.PetNum].CurrentTemp >= Application.player.pets[Application.PetNum].AmbientTemp)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp <= Application.player.pets[Application.PetNum].AmbientTemp)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            if (Application.player.pets[Application.PetNum].CurrentTemp >= 50)
            {
                for (int i = 1; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= 45)
            {
                for (int i = 2; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= 40)
            {
                for (int i = 3; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= 35)
            {
                for (int i = 4; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= 30)
            {
                for (int i = 5; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= 25)
            {
                for (int i = 6; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= 20)
            {
                for (int i = 7; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= 15)
            {
                for (int i = 8; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= 10)
            {
                for (int i = 9; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= 5)
            {
                for (int i = 10; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= 5)
            {
                for (int i = 11; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= 0)
            {
                for (int i = 12; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= -5)
            {
                for (int i = 13; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= -10)
            {
                for (int i = 14; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= -15)
            {
                for (int i = 15; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= -20)
            {
                for (int i = 16; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= -25)
            {
                for (int i = 17; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= -30)
            {
                for (int i = 18; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= -35)
            {
                for (int i = 19; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= -40)
            {
                for (int i = 20; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= -45)
            {
                for (int i = 21; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
            else if (Application.player.pets[Application.PetNum].CurrentTemp >= -50)
            {
                for (int i = 19; i <= 21; i++)
                {
                    Console.SetCursorPosition(6, 6 + i);
                    Console.WriteLine("▓");
                }
            }
        }

        public void ControledPet()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(28, 3);
            Console.WriteLine("               ");
            Console.SetCursorPosition(28, 3);
            Console.WriteLine(Application.player.pets[Application.PetNum].Name);

            Console.SetCursorPosition(28, 4);
            Console.WriteLine("               ");
            Console.SetCursorPosition(28, 4);
            Console.WriteLine(Application.player.pets[Application.PetNum].petType);
            
        }

        public void OtherPets()
        {
            int petY = 9;
            int petsNumber = 0;

            for (int i = 1; i <= Application.player.pets.Count; i++)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(28, petY + i);
                petY++;
                Console.WriteLine(Application.player.pets[petsNumber].Name);

                Console.SetCursorPosition(28, petY + i);
                Console.WriteLine(Application.player.pets[petsNumber].petType);

                petY++;
                petsNumber++;
            }
        }

        public void PetStatistics()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(66, 3);
            Console.Write("   ");
            Console.SetCursorPosition(66, 3);
            Console.Write(Application.player.pets[Application.PetNum].Happines);
            Console.SetCursorPosition(72, 3);

            Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");

            if (Application.player.pets[Application.PetNum].Happines == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 3);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Happines <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 3);

                Console.Write("▓");
            }
            else if (Application.player.pets[Application.PetNum].Happines <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 3);

                Console.Write("▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Happines <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 3);

                Console.Write("▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Happines <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 3);

                Console.Write("▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Happines <= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 3);

                Console.Write("▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Happines <= 60)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 3);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Happines <= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 3);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Happines <= 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 3);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Happines <= 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 3);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Happines <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 3);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            


            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(66, 5);
            Console.Write("   ");
            Console.SetCursorPosition(66, 5);
            Console.Write(Application.player.pets[Application.PetNum].Food);
            Console.SetCursorPosition(72, 5);

            Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");

            if (Application.player.pets[Application.PetNum].Food == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 5);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Food <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 5);

                Console.Write("▓");
            }
            else if (Application.player.pets[Application.PetNum].Food <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 5);

                Console.Write("▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Food <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 5);

                Console.Write("▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Food <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 5);

                Console.Write("▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Food <= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 5);

                Console.Write("▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Food <= 60)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 5);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Food <= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 5);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Food <= 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 5);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Food <= 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 5);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Food <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 5);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(66, 7);
            Console.Write("   ");
            Console.SetCursorPosition(66, 7);
            Console.Write(Application.player.pets[Application.PetNum].Health);
            Console.SetCursorPosition(72, 7);

            Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");

            if (Application.player.pets[Application.PetNum].Health == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 7);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Health <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 7);

                Console.Write("▓");
            }
            else if (Application.player.pets[Application.PetNum].Health <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 7);

                Console.Write("▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Health <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 7);

                Console.Write("▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Health <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 7);

                Console.Write("▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Health <= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 7);

                Console.Write("▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Health <= 60)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 7);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Health <= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 7);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Health <= 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 7);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Health <= 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 7);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Health <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 7);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(66, 9);
            Console.Write("   ");
            Console.SetCursorPosition(66, 9);
            Console.Write(Application.player.pets[Application.PetNum].Energy);
            Console.SetCursorPosition(72, 9);

            Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");

            if (Application.player.pets[Application.PetNum].Energy == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 9);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Energy <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 9);

                Console.Write("▓");
            }
            else if (Application.player.pets[Application.PetNum].Energy <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 9);

                Console.Write("▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Energy <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 9);

                Console.Write("▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Energy <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 9);

                Console.Write("▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Energy <= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 9);

                Console.Write("▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Energy <= 60)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 9);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Energy <= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 9);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Energy <= 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 9);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Energy <= 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 9);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Energy <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 9);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(66, 11);
            Console.Write("   ");
            Console.SetCursorPosition(66, 11);
            Console.Write(Application.player.pets[Application.PetNum].Cleanness);
            Console.SetCursorPosition(72, 11);

            Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");

            if (Application.player.pets[Application.PetNum].Cleanness == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 11);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Cleanness <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 11);

                Console.Write("▓");
            }
            else if (Application.player.pets[Application.PetNum].Cleanness <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(72, 11);

                Console.Write("▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Cleanness <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 11);

                Console.Write("▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Cleanness <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 11);

                Console.Write("▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Cleanness <= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 11);

                Console.Write("▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Cleanness <= 60)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 11);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Cleanness <= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 11);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Cleanness <= 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 11);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Cleanness <= 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 11);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }
            else if (Application.player.pets[Application.PetNum].Cleanness <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(72, 11);

                Console.Write("▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓");
            }

        }

        public void Inventory()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(61, 17);
            Console.WriteLine("     ");
            Console.SetCursorPosition(61, 17);
            Console.WriteLine(Application.player.inventory.Coin);

            Console.SetCursorPosition(66, 19);
            Console.WriteLine(Application.player.inventory.vegetables.Count);
            Console.SetCursorPosition(66, 20);
            Console.WriteLine(Application.player.inventory.meats.Count);
            Console.SetCursorPosition(66, 21);
            Console.WriteLine(Application.player.inventory.fishs.Count);

            Console.SetCursorPosition(65, 23);
            Console.WriteLine(Application.player.inventory.iceCubes.Count);
            Console.SetCursorPosition(65, 24);
            Console.WriteLine(Application.player.inventory.balls.Count);
            Console.SetCursorPosition(65, 25);
            Console.WriteLine(Application.player.inventory.pumpkins.Count);

            if(Application.player.inventory.iceCubes.Count >= 1)
            {
                Console.SetCursorPosition(77, 23);
                Console.WriteLine(Application.player.inventory.iceCubes[Application.player.inventory.iceCubes.Count - 1].UseAmount);
                Console.SetCursorPosition(82, 23);
                Console.WriteLine(Application.player.inventory.iceCubes[Application.player.inventory.iceCubes.Count - 1].UseAmountLeft);
            }
            else
            {
                Console.SetCursorPosition(54, 23);
                Console.Write("Ice Cube :        Use     /     ");
            }

            if(Application.player.inventory.balls.Count >= 1)
            {
                Console.SetCursorPosition(77, 24);
                Console.WriteLine(Application.player.inventory.balls[Application.player.inventory.balls.Count - 1].UseAmount);
                Console.SetCursorPosition(82, 24);
                Console.WriteLine(Application.player.inventory.balls[Application.player.inventory.balls.Count - 1].UseAmountLeft);
            }
            else
            {
                Console.SetCursorPosition(54, 24);
                Console.Write("Ball     :        Use     /     ");
            }
            
            if(Application.player.inventory.pumpkins.Count >= 1)
            {
                Console.SetCursorPosition(77, 25);
                Console.WriteLine(Application.player.inventory.pumpkins[Application.player.inventory.pumpkins.Count - 1].UseAmount);
                Console.SetCursorPosition(82, 25);
                Console.WriteLine(Application.player.inventory.pumpkins[Application.player.inventory.pumpkins.Count - 1].UseAmountLeft);
            }
            else
            {
                Console.SetCursorPosition(54, 25);
                Console.Write("Pumpkin  :        Use     /     ");
            }

            Console.SetCursorPosition(63, 27);
            Console.WriteLine(Application.player.inventory.typeAs.Count);
            Console.SetCursorPosition(63, 28);
            Console.WriteLine(Application.player.inventory.typeBs.Count);
            Console.SetCursorPosition(63, 29);
            Console.WriteLine(Application.player.inventory.typeXs.Count);
        }

        public void Keys()
        {
            
        }
    }
}
