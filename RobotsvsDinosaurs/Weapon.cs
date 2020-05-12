using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Weapon
    {
        //member variables (Has A)
        public string Type;


        //member methods (Can Do)
        public void WeaponType()
        {
            Console.WriteLine("Please Select Your Weapon.");
            Console.WriteLine("1: Sword");
            Console.WriteLine("2: Assault Rifle");
            Console.WriteLine("3: Machete");
            Console.WriteLine("4: Nuclear Gun");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("You have selected the Sword");
                    break;
                case "2":
                    Console.WriteLine("You have selected the Assault Rifle");
                    break;
                case "3":
                    Console.WriteLine("You have selected the Machete");
                    break;
                case "4":
                    Console.WriteLine("You have selected the Nuclear Gun");
                    break;
                default:
                    Console.WriteLine("Your weapon inut was not valid");
                    WeaponType();
                    break;
                   

    

            }
        
        }
          
    }

}
