using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Battlefield
    {
        public Herd herd;
        public Fleet fleet;

        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

        public void MakeRobotAttack(Robots robot)
        {
            int userInput = AttackOptions(true);
            robot.Attack(herd.dinosaurs[userInput]);
            if (herd.dinosaurs[userInput].dinohealth <= 0)
            {
                Console.WriteLine(herd.dinosaurs[userInput].type + "has been killed by opponent");
                herd.dinosaurs.RemoveAt(userInput);
            }
        }

        public void MakeDinoAttack(Dinosaur dinosaur)
        {
            int userInput = AttackOptions(false);
            dinosaur.Attack(fleet.robots[userInput]);
            if(fleet.robots[userInput].Health <= 0)
            {
                Console.WriteLine(fleet.robots[userInput].Name + "has been killed by opponent");
                fleet.robots.RemoveAt(userInput);
            }
        }

        public int AttackOptions(bool isRobotTurn)
        {
            if(isRobotTurn == true)
            {
                Console.WriteLine("Please select the dinosaur you would like to attack");
                for (int i = 0; i < herd.dinosaurs.Count; i++)
                {
                    Console.WriteLine((i) + herd.dinosaurs[i].type);
                }
            }
            else
            {
                Console.WriteLine("Please select the robot you would like to attach");
                for (int i = 0; i < fleet.robots.Count; i++)
                {
                    Console.WriteLine((i) + fleet.robots[i].Name);
                }
            }
            string userInput = Console.ReadLine();
            return Convert.ToInt32(userInput);
        }
        public void BattleWinner()
        {
            if(fleet.robots.Count == 0)
            {
                Console.WriteLine("Congratulation to the Dinosaurs!!! You have won!");
            }
            else if(herd.dinosaurs.Count == 0)
            {
                Console.WriteLine("Congratulations to the Robots!!! You have won!");
            }
        }
	}
           
}







    }
}
