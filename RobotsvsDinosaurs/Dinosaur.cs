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
            energy -= 10;

        }
    public void SelectAttackType()
        {
            Console.WriteLine("Please Select your Attack Type: Dragon Breath, Tail Spin, Bite");
            string attackType = Console.ReadLine();

            switch (attackType)
            {
                case "Dragon Breath":
                    Console.WriteLine("You have selected Dragon Breath");
                    break;
                case "Tail Spin":
                    Console.WriteLine("You have selected Tail Spin");
                    break;
                case "Bite":
                    Console.WriteLine("You have selected Bite");
                    break;
                default:
                    Console.WriteLine("This is an invalid selection");
                    break;



            }

        }
    }



   
}
