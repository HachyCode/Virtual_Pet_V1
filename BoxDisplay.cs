using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class BoxDisplay
    {
        //varible of box characters
        private static string boxLineX = "═";
        private static string boxLineY = "║";
        private static string boxCornTopL = "╔";
        private static string boxCornTopR = "╗";
        private static string boxCornBotL = "╚";
        private static string boxCornBotR = "╝";

        //methods to display each of boxes
        public void TempInfoBox()
        {
            BoxLineX(2, 0, 16);//Top
            BoxLineX(2, 35, 16);//Bottom

            BoxLineY(1, 1, 34);//Left
            BoxLineY(17, 1, 34);//Right

            BoxCornTopL(1, 0);
            BoxCornTopR(17, 0);
            BoxCornBotL(1, 35);
            BoxCornBotR(17, 35);
        }

        public void ControledPetBox()
        {
            BoxLineX(20, 0, 30);//Top
            BoxLineX(20, 6, 30);//Bottom

            BoxLineY(19, 1, 5);//Left
            BoxLineY(50, 1, 5);//Right

            BoxCornTopL(19, 0);
            BoxCornTopR(50, 0);
            BoxCornBotL(19, 6);
            BoxCornBotR(50, 6);
        }

        public void OtherPetsBox()
        {
            int pets = 3 * Application.player.pets.Count;

            BoxLineX(20, 7, 30);//Top
            BoxLineX(20, 10 + pets, 30);//Bottom

            BoxLineY(19, 8, 2 + pets);//Left
            BoxLineY(50, 8, 2 + pets);//Right

            BoxCornTopL(19, 7);
            BoxCornTopR(50, 7);
            BoxCornBotL(19, 10 + pets);
            BoxCornBotR(50, 10 + pets);
        }

        public void PetStatisticsBox()
        {
            BoxLineX(53, 0, 39);//Top
            BoxLineX(53, 13, 39);//Bottom

            BoxLineY(52, 1, 12);//Left
            BoxLineY(92, 1, 12);//Right

            BoxCornTopL(52, 0);
            BoxCornTopR(92, 0);
            BoxCornBotL(52, 13);
            BoxCornBotR(92, 13);
        }

        public void InventoryBox()
        {
            BoxLineX(53, 14, 35);//Top
            BoxLineX(53, 31, 35);//Bottom

            BoxLineY(52, 15, 16);//Left
            BoxLineY(88, 15, 16);//Right

            BoxCornTopL(52, 14);
            BoxCornTopR(88, 14);
            BoxCornBotL(52, 31);
            BoxCornBotR(88, 31);
        }

        public void KeysBox()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            BoxLineX(94, 0, 24);//Top
            BoxLineX(94, 32, 24);//Bottom

            BoxLineY(93, 1, 31);//Left
            BoxLineY(118, 1, 31);//Right

            BoxCornTopL(93, 0);
            BoxCornTopR(118, 0);
            BoxCornBotL(93, 32);
            BoxCornBotR(118, 32);
        }

        //Methodes to display multiple charecters
        private void BoxLineX( int _x, int _y, int _amount)
        {
            Console.SetCursorPosition(_x, _y);
            for (int i = 1; i <= _amount ;i++)
            {
                Console.Write(boxLineX);
            }
        }
        private void BoxLineY(int _x, int _y, int _amount)
        {
            for (int i = 1; i <= _amount; i++)
            {
                Console.SetCursorPosition(_x, _y);
                Console.WriteLine(boxLineY);
                _y++;
            }
        }

        //Methods to display corners
        private void BoxCornTopL(int _x, int _y)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(boxCornTopL);
        }
        private void BoxCornTopR(int _x, int _y)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(boxCornTopR);
        }
        private void BoxCornBotL(int _x, int _y)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(boxCornBotL);
        }
        private void BoxCornBotR(int _x, int _y)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(boxCornBotR);
        }
    }
}
