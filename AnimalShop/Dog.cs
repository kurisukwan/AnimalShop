using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShop
{
    class Dog : Animal
    {
        public bool barksAlot { get; private set; }
        public bool likesToWalk { get; private set; }
        public float runSpeed { get; private set; }     //km per hour
        public Dog(string name, int price, string personality, bool barksAlot, bool likesToWalk, float runSpeed)
            : base(name, price, personality)
        {
            this.barksAlot = barksAlot;
            this.likesToWalk = likesToWalk;
            this.runSpeed = runSpeed;
        }
        public override void TellStory()
        {
            string barkQuestion = (barksAlot) ? "barks alot" : "does not like to bark";
            string walkQuestion = (likesToWalk) ? "likes" : "does not like";
            Console.WriteLine($"\n\nThanks for your purchase and giving {name} a new home! " +
                $"\n\n{name} is a {personality} dog. {name} {barkQuestion} and {walkQuestion} to take walks." +
                $"\n{name} can also run at a speed of {runSpeed} km per hour!");
        }
    }
}
