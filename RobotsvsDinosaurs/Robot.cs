using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Robot
    {   //Member Variables 
        public string Name;
        public int Health;
        public int PowerLevel;
        Weapon robotweapon;
        


        //Constructor
        public Robot(Weapon SelectedWeapon)
        {
            Name = NameYourRobot();
            Health = 5;
            robotweapon = SelectedWeapon;
            PowerLevel = 10;
            

        }



        //Member Methods
        public string NameYourRobot()
        {
            Console.WriteLine("What is your robots name?");
            string input = Console.ReadLine();
            return input;
        }

        public void Attack(Dinosaur dinoToAttack)
        {
            dinoToAttack.dinoHealth -= robotweapon.attackPower;
            PowerLevel--;
        }

    }
}
