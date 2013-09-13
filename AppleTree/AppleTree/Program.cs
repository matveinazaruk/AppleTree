using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_LAB_1
{
    class Program
    {

        static void Menu()
        {
            Console.WriteLine("commands: ");
            Console.WriteLine("grow");
            Console.WriteLine("exit");
            Console.WriteLine("shake");
            Console.WriteLine("enter smth please");
        }

        static void Act(string command, Tree appleTree)
        {
            switch (command)
            {
                case "grow":
                    Console.WriteLine("apple amount before growth: {0}", appleTree.AppleAmount);
                    appleTree.Grow();
                    Console.WriteLine("apple amount after growth: {0}", appleTree.AppleAmount);
                    break;
                case "exit":
                    Console.WriteLine("goobye");
                    break;
                case "shake":
                    Console.WriteLine("apple amount before shake: {0}", appleTree.AppleAmount);
                    appleTree.Shake();
                    Console.WriteLine("apple amount after shake: {0}", appleTree.AppleAmount);
                    break;
                default:
                    Console.WriteLine("wrong command");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            Tree appleTree = new Tree(rand.Next(0, 10));


            string command = "";
            while (!command.Equals("exit"))
            {
                Console.Clear();
                Menu();
                command = Console.ReadLine();
                Act(command, appleTree);
                Console.ReadKey();
            }
        }



    }
}
