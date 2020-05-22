﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Robot
    {   //Member Variables 
        public string Name;
        public int Health;
        public int PowerLevel;
        public Weapon weapon;


        //Constructor
        public Robot()
        {
            Name = NameYourRobot();
            Health = 100;
            PowerLevel = 100;
            weapon = SelectWeapon();
        }



        //Member Methods
        public string NameYourRobot()
        {
            Console.WriteLine("What is your robots name?");
            string input = Console.ReadLine();
            return input;
        }

        public Weapon SelectWeapon()
        {

            Console.WriteLine("Please Select Your Weapon of Choice: Sword,  Machete,  Rifle!");
            string robotweapon = Console.ReadLine();
          
            switch (robotweapon)
            {
                case "Sword":
                    Console.WriteLine("You have selected a Sword");
                    break;
                case "Machete":
                    Console.WriteLine("You have selected a Machete");
                    break;
                case "Rifle":
                    Console.WriteLine("You have selected a Rifle");
                    break;
                default:
                    Console.WriteLine("Your Weapon Choice is Invalid, please try again");
                    break;
            }
        }
        public void Attack(Dinosaur dinosaur)
        {
            Console.WriteLine(dinosaur.type + "is attacked by" + Name);
            dinosaur.dinohealth -= weapon.attackPower;
            PowerLevel -= 10;
        }
            
    }
}   
