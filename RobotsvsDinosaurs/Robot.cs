using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Robots
    {   //Member Variables 
        public string Name;
        public int Health;
        public int PowerLevel;
        public Weapon weapon;


        //Constructor
        public Robots()
        {
            Name = NameYourRobot();
            Health = 100;
            PowerLevel = 100;
            SelectWeapon();
            
        }



        //Member Methods
        public string NameYourRobot()
        {
            Console.WriteLine("What is your robots name?");
            string input = Console.ReadLine();
            return input;
        }

        public int SelectWeapon()
        {
            List<Weapon> weapons = new List<Weapon>() { new Weapon("Machete", 48), new Weapon("Rifle", 51), new Weapon("Nuclear Gun", 60)};
            Console.WriteLine("Please select your weapon that you would like to take to battle");
            for (int i = 0; i < weapons.Count; i++)
            {
                Console.WriteLine((i) + weapons[i].type);
                
            }
            string userInput = Console.ReadLine();
            return Convert.ToInt32(userInput);

        }
        public void Attack(Dinosaur dinosaur)
        {
            Console.WriteLine(dinosaur.type + "is attacked by" + Name);
            dinosaur.dinohealth -= weapon.attackPower;
            PowerLevel -= 10;
        }
            
    }
}   
