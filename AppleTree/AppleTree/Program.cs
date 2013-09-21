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
            Console.WriteLine("blossom");
            Console.WriteLine("grow");
            Console.WriteLine("shake");
            Console.WriteLine("info");
            Console.WriteLine("exit");
            Console.WriteLine("enter smth please");
        }

        static void Act(string command, Tree appleTree)
        {
            switch (command)
            {
                case "blossom":
                    appleTree.Blossom();
                    break;
                case "grow":
                    appleTree.Grow();
                    break;
                case "exit":
                    Console.WriteLine("goobye");
                    break;
                case "shake":
                    appleTree.Shake();
                    break;
                case "info":
                    appleTree.printInfo("now");
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
