using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Herd
    {
        public List<Dinosaur> dinosaurs;

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();

            Dinosaur dino1 = new Dinosaur("T-Rex");
            Dinosaur dino2 = new Dinosaur("Spino");
            Dinosaur dino3 = new Dinosaur("Brachio");

            dinosaurs.Add(dino1);
            dinosaurs.Add(dino2);
            dinosaurs.Add(dino3);
        }
        
           
        
    }
}
