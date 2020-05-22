using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Fleet
    {
        public List<Robots> robots;

        
        public Fleet()
        {
             robots = new List<Robots>();

             Robots robot1 = new Robots();
             Robots robot2 = new Robots();
             Robots robot3 = new Robots();

            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);


        }
   
    }
}
