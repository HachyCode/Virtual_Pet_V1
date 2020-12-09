using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetV1
{
    class Inventory
    {
        //Coin veriable
        private int coin = 100;
        public int Coin{ get { return coin; } }

        //Food List
        public List<Vegetable> vegetables = new List<Vegetable>();
        public List<Meat> meats = new List<Meat>();
        public List<Fish> fishs = new List<Fish>();

        //Toy List
        public List<IceCube> iceCubes = new List<IceCube>();
        public List<Ball> balls = new List<Ball>();
        public List<Pumpkin> pumpkins = new List<Pumpkin>();

        //Medicine List
        public List<TypeA> typeAs = new List<TypeA>();
        public List<TypeB> typeBs = new List<TypeB>();
        public List<TypeX> typeXs = new List<TypeX>();

        //Item control Methods
        public void AddItem(string _type)
        {
            //food
            if (_type == "Vegetable")
            {
                vegetables.Add(new Vegetable());
            }
            else if (_type == "Meat")
            {
                meats.Add(new Meat());
            }
            else if (_type == "Fish")
            {
                fishs.Add(new Fish());
            }

            //toy
            else if (_type == "IceCube")
            {
                iceCubes.Add(new IceCube());
            }
            else if (_type == "Ball")
            {
                balls.Add(new Ball());
            }
            else if (_type == "Pumpkin")
            {
                pumpkins.Add(new Pumpkin());
            }

            //medicine
            else if (_type == "TypeA")
            {
                typeAs.Add(new TypeA());
            }
            else if (_type == "TypeB")
            {
                typeBs.Add(new TypeB());
            }
            else if (_type == "TypeX")
            {
                typeXs.Add(new TypeX());
            }

            //error
            else
            {
                //error
            }
        }
        public void RemoveItem(string _type)
        {
            //food
            if (_type == "Vegetable")
            {
                vegetables.RemoveAt(vegetables.Count - 1);
            }
            else if (_type == "Meat")
            {
                meats.RemoveAt(meats.Count - 1);
            }
            else if (_type == "Fish")
            {
                fishs.RemoveAt(fishs.Count - 1);
            }

            //toy
            else if (_type == "IceCube")
            {
                iceCubes.RemoveAt(iceCubes.Count - 1);
            }
            else if (_type == "Ball")
            {
                balls.RemoveAt(balls.Count - 1);
            }
            else if (_type == "Pumpkin")
            {
                pumpkins.RemoveAt(pumpkins.Count - 1);
            }

            //medicine
            else if (_type == "TypeA")
            {
                typeAs.RemoveAt(typeAs.Count - 1);
            }
            else if (_type == "TypeB")
            {
                typeBs.RemoveAt(typeBs.Count - 1);
            }
            else if (_type == "TypeX")
            {
                typeXs.RemoveAt(typeXs.Count - 1);
            }

            //error
            else
            {
                //error
            }
        }

        //Coint control Methods
        public void AddCoin(int _amount)
        {
            coin += (_amount);
        }

        public void MinusCoin(int _amount)
        {
            coin -= (_amount);
        }
    }
}
