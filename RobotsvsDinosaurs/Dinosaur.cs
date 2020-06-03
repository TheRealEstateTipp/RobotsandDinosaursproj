using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Dinosaur
    {
        public string type;
        public int dinohealth;
        public int energy;
        public int attackpower;

    public Dinosaur()
        {
            SelectDinoType();
            dinohealth = 100;
            energy = 100;
            attackpower = 48;
        }
    public void Attack(Robots robot)
        {
            Console.WriteLine(robot.Name + "is attacked by" + type);
            robot.Health -= attackpower;
            energy -= 10;

        }
    public int SelectDinoType()
        {
            string[] dinosaurs = new string[] { "T-Rex", "Spino", "Brachio" };
            Console.WriteLine("Please select the type of dinosaur your would like battle with");
            string input = Console.ReadLine();
            return Convert.ToInt32(input);
        }
    }



   
}
