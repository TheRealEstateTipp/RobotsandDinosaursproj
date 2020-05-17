using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon selectedWeapon = new Weapon();
            Console.WriteLine("Please select a weapon type");
            string input = Console.ReadLine();

            switch (input)
            {
                case "Sword":
                    selectedWeapon = new Weapon("Sword", 10);
                    break;
                case "Axe":
                    selectedWeapon = new Weapon("Axe", 5);
                    break;
                default:
                    break;
            }
            Robot Tom = new Robot(selectedWeapon);
        }
    }
}
