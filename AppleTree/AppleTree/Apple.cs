using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_LAB_1
{
    class Apple
    {
        private int mass;
        private int stones;

        public Apple()
        {
            Random rand = new Random();
            mass = rand.Next(50, 100);
            stones = rand.Next(1, 10);
        }

        public int Mass
        {
            get { return mass; }
        }

        public int Stones
        {
            get { return stones; }
        }
    }
}
