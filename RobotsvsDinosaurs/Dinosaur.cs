﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Dinosaur
    {
        public string type;
        public int health;
        public int energy;
        public int attackpower;

    public Dinosaur(string type)
        {
            this.type = type;
            health = 100;
            energy = 100;
            attackpower = 48;
        }
    }

   
}
