using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_LAB_1
{
    class Tree
    {
        private List<Apple> apples;
        private int flowers;
        private int stones;

        public Tree()
        {
            Random rand = new Random();
            apples = new List<Apple>();
            flowers = rand.Next(50, 250);
        }

        public Tree(int numberOfApples)
        {
            Random rand = new Random();
            flowers = rand.Next(50, 60);
            int amount = Math.Min(flowers, numberOfApples);
            apples = new List<Apple>(numberOfApples);
            for (int i = 0; i < amount; i++)
            {
                Apple ap = new Apple();
                apples.Add(ap);
            }
            flowers -= numberOfApples;
        }

        public void Grow()
        {
            if (flowers == 0) {
                Console.WriteLine("apples amount is max {0}, there is no flowers", this.AppleAmount);
                return;
            }
            printInfo("before");
            Random rand = new Random();
            int applesGrowing = rand.Next(1, flowers);
            flowers -= applesGrowing;
            Console.WriteLine("GROWING");
            for (int i = 0; i < applesGrowing; i++)
            {
                Apple apple = new Apple();
                apples.Add(apple);
            }
            reCountStones();
            printInfo("after");    
        }

        public void Shake()
        {
            if (AppleAmount == 0) {
                Console.WriteLine("there are no more apples");
                return;       
            }
            printInfo("before");
            Random rand = new Random();
            int applesFalling = rand.Next(0, apples.Count);
            Console.WriteLine("SHAKING");
            for (int i = 0; i < applesFalling; i++)
            {
                Apple apple = new Apple();
                apples.RemoveAt(0);
            }
            reCountStones();
            printInfo("after");
        }

        private void reCountStones() {
            stones = 0;
            for (int i = 0; i < apples.Count; i++) {
                stones += apples[i].Stones;                
            }
        }

        private void printInfo(string when) {
            Console.WriteLine("apples amount {0} shake: {1}", when, this.AppleAmount);
            Console.WriteLine("stones amount {0} growth: {1}", when, this.stones);            
        }

        public int AppleAmount
        {
            get { return apples.Count; }
        }
    }
}
