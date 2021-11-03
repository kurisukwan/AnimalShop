using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShop
{
    class Cat : Animal
    {
        public bool nocturnal { get; private set; }
        public bool canClimbTrees { get; private set; }
        public float jumpHeight { get; private set; }

        public Cat(string name, int price, string personality, bool nocturnal, bool canClimbTrees, float jumpHeight)
            : base(name, price, personality)
        {
            this.nocturnal = nocturnal;
            this.canClimbTrees = canClimbTrees;
            this.jumpHeight = jumpHeight;
        }
        public override void TellStory()
        {
            string nocturnalQuestion = (nocturnal) ? "is" : "is not";
            string climberQuestion = (canClimbTrees) ? "can" : "cannot";
            Console.WriteLine($"\n\nThanks for your purchase and giving {name} a new home! " +
                $"\n\n{name} is a {personality} cat. {name} {nocturnalQuestion} nocturnal and {climberQuestion} clim trees." +
                $"\n{name} can also jump up to {jumpHeight} meters!");
        }
    }
}
