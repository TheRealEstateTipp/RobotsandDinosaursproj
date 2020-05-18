using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Dinosaur
    {
        public string type;
        public int dinohealth;
        public int energy;
        public int attackpower;

    public Dinosaur(string type)
        {
            this.type = type;
            dinohealth = 100;
            energy = 100;
            attackpower = 48;
        }
    public void Attack(Robot robot)
        {
            Console.WriteLine(robot.Name + "is attacked by" + type);
            robot.Health -= attackpower;
        }
    }


   
}
