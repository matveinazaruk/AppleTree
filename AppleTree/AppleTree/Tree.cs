using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_LAB_1
{
    class Tree
    {
        private List<Apple> apples;

        public Tree()
        {
            apples = new List<Apple>();
        }

        public Tree(int numberOfApples)
        {
            apples = new List<Apple>(numberOfApples);
            for (int i = 0; i < numberOfApples; i++)
            {
                Apple ap = new Apple();
                apples.Add(ap);
            }
        }

        public void Grow()
        {
            Random rand = new Random();
            int applesGrowing = rand.Next(3, 20);
            for (int i = 0; i < applesGrowing; i++)
            {
                Apple apple = new Apple();
                apples.Add(apple);
            }
        }

        public int AppleAmount
        {
            get { return apples.Count; }
        }
    }
}
