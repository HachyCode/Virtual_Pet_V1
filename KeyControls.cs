using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VirtualPetV1
{
    class KeyControls
    {
        //methods
        public void Run()
        {
            while (!Application.end)
            {
                KeyPresses();
            }
        }

        public void KeyPresses() //Chacks if key are pressed executs a specific task then key is pressed
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                if (keyPressed == ConsoleKey.Escape)
                {
                    Application.end = true;
                    Console.Clear();
                    Console.WriteLine("GAME OVER");
                    Thread.Sleep(100);
                }

                //Buy
                else if (keyPressed == ConsoleKey.D1 || keyPressed == ConsoleKey.NumPad1)//if keyboard dont have num pad
                {
                    //vegetables
                    Application.player.inventory.AddItem("Vegetable");
                    Application.player.inventory.MinusCoin(Application.player.inventory.vegetables[0].Cost);
                }
                else if (keyPressed == ConsoleKey.D2 || keyPressed == ConsoleKey.NumPad2)
                {
                    //meat
                    Application.player.inventory.AddItem("Meat");
                    Application.player.inventory.MinusCoin(Application.player.inventory.meats[0].Cost);
                }
                else if (keyPressed == ConsoleKey.D3 || keyPressed == ConsoleKey.NumPad3)
                {
                    //fish
                    Application.player.inventory.AddItem("Fish");
                    Application.player.inventory.MinusCoin(Application.player.inventory.fishs[0].Cost);
                }


                else if (keyPressed == ConsoleKey.D4 || keyPressed == ConsoleKey.NumPad4)
                {
                    //Ice Cube
                    Application.player.inventory.AddItem("IceCube");
                    Application.player.inventory.MinusCoin(Application.player.inventory.iceCubes[0].Cost);
                }
                else if (keyPressed == ConsoleKey.D5 || keyPressed == ConsoleKey.NumPad5)
                {
                    //Ball
                    Application.player.inventory.AddItem("ball");
                    Application.player.inventory.MinusCoin(Application.player.inventory.balls[0].Cost);
                }
                else if (keyPressed == ConsoleKey.D6 || keyPressed == ConsoleKey.NumPad6)
                {
                    //Pumpkin
                    Application.player.inventory.AddItem("Pumpkin");
                    Application.player.inventory.MinusCoin(Application.player.inventory.pumpkins[0].Cost);
                }

                else if (keyPressed == ConsoleKey.D7 || keyPressed == ConsoleKey.NumPad7)
                {
                    //TypeA
                    Application.player.inventory.AddItem("TypeA");
                    Application.player.inventory.MinusCoin(Application.player.inventory.typeAs[0].Cost);
                }
                else if (keyPressed == ConsoleKey.D8 || keyPressed == ConsoleKey.NumPad8)
                {
                    //TypeB
                    Application.player.inventory.AddItem("TypeB");
                    Application.player.inventory.MinusCoin(Application.player.inventory.typeBs[0].Cost);
                }
                else if (keyPressed == ConsoleKey.D9 || keyPressed == ConsoleKey.NumPad9)
                {
                    //TypeX
                    Application.player.inventory.AddItem("TypeX");
                    Application.player.inventory.MinusCoin(Application.player.inventory.typeXs[0].Cost);
                }

                else if (keyPressed == ConsoleKey.D0 || keyPressed == ConsoleKey.NumPad0)
                {
                    bool done = false;
                    //pet

                    while(!done)
                    {
                        if (!Application.Updatating)
                        {
                            done = true;
                            Application.player.AddPet();
                            Application.sdisplay.SDisplay();
                        }
                        else
                        {
                            Thread.Sleep(100);
                        }
                    }
                }

                //Interation
                else if (keyPressed == ConsoleKey.A)
                {   
                    //feed vegetables
                    if (Application.player.inventory.vegetables.Count > 0)
                    {
                        Application.player.pets[Application.PetNum].ControlHappines  (Application.player.inventory.vegetables[0].HappinesValue);
                        Application.player.pets[Application.PetNum].ControlFood      (Application.player.inventory.vegetables[0].FoodValue);
                        Application.player.pets[Application.PetNum].ControlHealth    (Application.player.inventory.vegetables[0].HealthValue);
                        Application.player.pets[Application.PetNum].ControlEnergy    (Application.player.inventory.vegetables[0].EnergyValue);
                        Application.player.pets[Application.PetNum].ControlCleanness (Application.player.inventory.vegetables[0].CleannessValue);

                        Application.player.inventory.RemoveItem("Vegetable");
                    }
                }
                else if (keyPressed == ConsoleKey.B)
                {
                    //feed meat  - PolarBaer & Lion
                    if (Application.player.pets[Application.PetNum].petType == PetType.PolarBear || Application.player.pets[Application.PetNum].petType == PetType.Lion)
                    {
                        if (Application.player.inventory.meats.Count > 0)
                        {
                            Application.player.pets[Application.PetNum].ControlHappines(Application.player.inventory.meats[0].HappinesValue);
                            Application.player.pets[Application.PetNum].ControlFood(Application.player.inventory.meats[0].FoodValue);
                            Application.player.pets[Application.PetNum].ControlHealth(Application.player.inventory.meats[0].HealthValue);
                            Application.player.pets[Application.PetNum].ControlEnergy(Application.player.inventory.meats[0].EnergyValue);
                            Application.player.pets[Application.PetNum].ControlCleanness(Application.player.inventory.meats[0].CleannessValue);

                            Application.player.inventory.RemoveItem("Meat");
                        }
                    }
                }  
                else if (keyPressed == ConsoleKey.C)
                {
                    //feed fish  - Dolphin & PolarBear
                    if (Application.player.pets[Application.PetNum].petType == PetType.Dolphin || Application.player.pets[Application.PetNum].petType == PetType.PolarBear)
                    {
                        if (Application.player.inventory.fishs.Count > 0)
                        {
                            Application.player.pets[Application.PetNum].ControlHappines(Application.player.inventory.fishs[0].HappinesValue);
                            Application.player.pets[Application.PetNum].ControlFood(Application.player.inventory.fishs[0].FoodValue);
                            Application.player.pets[Application.PetNum].ControlHealth(Application.player.inventory.fishs[0].HealthValue);
                            Application.player.pets[Application.PetNum].ControlEnergy(Application.player.inventory.fishs[0].EnergyValue);
                            Application.player.pets[Application.PetNum].ControlCleanness(Application.player.inventory.fishs[0].CleannessValue);

                            Application.player.inventory.RemoveItem("Fish");
                        }
                    }
                }

                else if (keyPressed == ConsoleKey.D)
                {
                    //play with IceCube  - PolarBaer
                    if (Application.player.pets[Application.PetNum].petType == PetType.PolarBear)
                    {
                        if (Application.player.inventory.iceCubes.Count > 0)
                        {
                            Application.player.inventory.iceCubes[Application.player.inventory.iceCubes.Count - 1].UseAmountLeft--;
                            Application.player.pets[Application.PetNum].ControlHappines(Application.player.inventory.iceCubes[0].HappinesValue);
                            Application.player.pets[Application.PetNum].ControlFood(Application.player.inventory.iceCubes[0].FoodValue);
                            Application.player.pets[Application.PetNum].ControlHealth(Application.player.inventory.iceCubes[0].HealthValue);
                            Application.player.pets[Application.PetNum].ControlEnergy(Application.player.inventory.iceCubes[0].EnergyValue);
                            Application.player.pets[Application.PetNum].ControlCleanness(Application.player.inventory.iceCubes[0].CleannessValue);

                        }


                        Console.WriteLine();
                        if (Application.player.inventory.iceCubes.Count >= 1) //I use two if insted of &&. It need to verify that there is ice cube in the list before cheaking a specific ice cubes UseAmountLEft value
                        {
                            if (Application.player.inventory.iceCubes[Application.player.inventory.iceCubes.Count - 1].UseAmountLeft == 0)
                            {
                                Application.player.inventory.RemoveItem("IceCube");
                            }
                        }
                    }
                }
                else if (keyPressed == ConsoleKey.E)
                {
                    //play with Ball  - Dolthine
                    if (Application.player.pets[Application.PetNum].petType == PetType.Dolphin)
                    {
                        if (Application.player.inventory.balls.Count > 0)
                        {
                            Application.player.inventory.balls[Application.player.inventory.balls.Count - 1].UseAmountLeft--;
                            Application.player.pets[Application.PetNum].ControlHappines(Application.player.inventory.balls[0].HappinesValue);
                            Application.player.pets[Application.PetNum].ControlFood(Application.player.inventory.balls[0].FoodValue);
                            Application.player.pets[Application.PetNum].ControlHealth(Application.player.inventory.balls[0].HealthValue);
                            Application.player.pets[Application.PetNum].ControlEnergy(Application.player.inventory.balls[0].EnergyValue);
                            Application.player.pets[Application.PetNum].ControlCleanness(Application.player.inventory.balls[0].CleannessValue);

                        }

                        Console.WriteLine();
                        if (Application.player.inventory.balls.Count >= 1) //I use two if insted of &&. It need to verify that there is ice cube in the list before cheaking a specific ice cubes UseAmountLEft value
                        {
                            if (Application.player.inventory.balls[Application.player.inventory.balls.Count - 1].UseAmountLeft == 0)
                            {
                                Application.player.inventory.RemoveItem("Ball");
                            }
                        }
                    }
                }
                else if (keyPressed == ConsoleKey.F)
                {
                    //play with Pumpkin  - Lion
                    if (Application.player.pets[Application.PetNum].petType == PetType.Lion)
                    {
                        if (Application.player.inventory.pumpkins.Count > 0)
                        {
                            Application.player.inventory.pumpkins[Application.player.inventory.pumpkins.Count - 1].UseAmountLeft--;
                            Application.player.pets[Application.PetNum].ControlHappines(Application.player.inventory.pumpkins[0].HappinesValue);
                            Application.player.pets[Application.PetNum].ControlFood(Application.player.inventory.pumpkins[0].FoodValue);
                            Application.player.pets[Application.PetNum].ControlHealth(Application.player.inventory.pumpkins[0].HealthValue);
                            Application.player.pets[Application.PetNum].ControlEnergy(Application.player.inventory.pumpkins[0].EnergyValue);
                            Application.player.pets[Application.PetNum].ControlCleanness(Application.player.inventory.pumpkins[0].CleannessValue);

                        }

                        Console.WriteLine();
                        if (Application.player.inventory.pumpkins.Count >= 1) //I use two if insted of &&. It need to verify that there is ice cube in the list before cheaking a specific ice cubes UseAmountLEft value
                        {
                            if (Application.player.inventory.pumpkins[Application.player.inventory.pumpkins.Count - 1].UseAmountLeft == 0)
                            {
                                Application.player.inventory.RemoveItem("Pumpkin");
                            }
                        }
                    }
                }

                else if (keyPressed == ConsoleKey.G)
                {
                    //feed type A
                    if (Application.player.inventory.typeAs.Count > 0)
                    {
                        Application.player.pets[Application.PetNum].ControlHappines  (Application.player.inventory.typeAs[0].HappinesValue);
                        Application.player.pets[Application.PetNum].ControlFood      (Application.player.inventory.typeAs[0].FoodValue);
                        Application.player.pets[Application.PetNum].ControlHealth    (Application.player.inventory.typeAs[0].HealthValue);
                        Application.player.pets[Application.PetNum].ControlEnergy    (Application.player.inventory.typeAs[0].EnergyValue);
                        Application.player.pets[Application.PetNum].ControlCleanness (Application.player.inventory.typeAs[0].CleannessValue);

                        Application.player.inventory.RemoveItem("TypeA");
                    }
                }
                else if (keyPressed == ConsoleKey.H)
                {
                    //feed type B
                    if (Application.player.inventory.typeBs.Count > 0)
                    {
                        Application.player.pets[Application.PetNum].ControlHappines  (Application.player.inventory.typeBs[0].HappinesValue);
                        Application.player.pets[Application.PetNum].ControlFood      (Application.player.inventory.typeBs[0].FoodValue);
                        Application.player.pets[Application.PetNum].ControlHealth    (Application.player.inventory.typeBs[0].HealthValue);
                        Application.player.pets[Application.PetNum].ControlEnergy    (Application.player.inventory.typeBs[0].EnergyValue);
                        Application.player.pets[Application.PetNum].ControlCleanness (Application.player.inventory.typeBs[0].CleannessValue);

                        Application.player.inventory.RemoveItem("TypeB");
                    }
                }
                else if (keyPressed == ConsoleKey.I)
                {
                    //feed type X
                    if (Application.player.inventory.typeXs.Count > 0)
                    {
                        Application.player.pets[Application.PetNum].ControlHappines  (Application.player.inventory.typeXs[0].HappinesValue);
                        Application.player.pets[Application.PetNum].ControlFood      (Application.player.inventory.typeXs[0].FoodValue);
                        Application.player.pets[Application.PetNum].ControlHealth    (Application.player.inventory.typeXs[0].HealthValue);
                        Application.player.pets[Application.PetNum].ControlEnergy    (Application.player.inventory.typeXs[0].EnergyValue);
                        Application.player.pets[Application.PetNum].ControlCleanness (Application.player.inventory.typeXs[0].CleannessValue);

                        Application.player.inventory.RemoveItem("TypeX");
                    }
                }

                else if (keyPressed == ConsoleKey.J)
                {
                    //Put to bed
                        Application.player.pets[Application.PetNum].ControlEnergy(100);
                }
                else if (keyPressed == ConsoleKey.K)
                {
                    //Bath
                    Application.player.pets[Application.PetNum].ControlCleanness(100);
                }

                else if (keyPressed == ConsoleKey.L)
                {
                    //Heater
                    Application.player.pets[Application.PetNum].HeaterOn = true;
                    Application.player.pets[Application.PetNum].CoolerOn = false;
                }
                else if (keyPressed == ConsoleKey.M)
                {
                    //Temp control Off
                    Application.player.pets[Application.PetNum].HeaterOn = false;
                    Application.player.pets[Application.PetNum].CoolerOn = false;
                }
                else if (keyPressed == ConsoleKey.N)
                {
                    //Cooler
                    Application.player.pets[Application.PetNum].HeaterOn = false;
                    Application.player.pets[Application.PetNum].CoolerOn = true;
                }

                else if (keyPressed == ConsoleKey.O)
                {
                    //Add pet
                    if (Application.PetNum < Application.player.pets.Count-1)
                    {
                        Application.PetNum++;
                    }
                    else
                    {
                        Application.PetNum = 0;
                    }
                }
            }
        }
    }
}
