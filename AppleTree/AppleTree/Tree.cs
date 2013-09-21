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
            apples = new List<Apple>();
        }

        public Tree(int numberOfApples)
        {
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
                Console.WriteLine("there is no flowers");
                return;
            }
            printInfo("before growth");
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
            printInfo("after growth");    
        }

        public void Shake()
        {
            if (AppleAmount == 0) {
                Console.WriteLine("there are no more apples");
                return;       
            }
            printInfo("before shake");
            Random rand = new Random();
            int applesFalling = rand.Next(0, apples.Count);
            Console.WriteLine("SHAKING");
            for (int i = 0; i < applesFalling; i++)
            {
                Apple apple = new Apple();
                apples.RemoveAt(0);
            }
            reCountStones();
            printInfo("after shake");
        }

        private void reCountStones() {
            stones = 0;
            for (int i = 0; i < apples.Count; i++) {
                stones += apples[i].Stones;                
            }
        }

        public void printInfo(string when) {
            Console.WriteLine("apples amount {0}: {1}", when, this.AppleAmount);
            Console.WriteLine("stones amount {0}: {1}", when, this.stones);            
        }

        public void Blossom(){
            Random rand = new Random();
            Console.WriteLine("TREE BLOSSOMS");            
            flowers = rand.Next(10, 200);
            Console.WriteLine("amount fo flowers: {0}", flowers);
        }

        public int AppleAmount
        {
            get { return apples.Count; }
        }
    }
}
