using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_LAB_1
{
    class Apple
    {
        private int mass;

        public Apple()
        {
            Random rand = new Random();
            mass = rand.Next(50, 100);
        }

        public int Mass
        {
            get { return mass; }
        }
    }
}
