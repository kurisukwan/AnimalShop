using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShop
{
    class Hamster : Animal 
    {
        public bool likesToSleep { get; private set; }
        public bool animalFriendly { get; private set; }
        public int sleepsHoursPerDay { get; private set; }
        public Hamster(string name, int price, string personality, bool likesToSleep, bool animalFriendly, int sleepsHoursPerDay)
            : base(name, price, personality)
        {
            this.likesToSleep = likesToSleep;
            this.animalFriendly = animalFriendly;
            this.sleepsHoursPerDay = sleepsHoursPerDay;
        }
        public override void TellStory()
        {
            string sleepQuestion = (likesToSleep) ? "sleeps alot" : "does not need much sleep";
            string friendlyQuestion = (animalFriendly) ? "likes" : "does not like";
            Console.WriteLine($"\n\nThanks for your purchase and giving {name} a new home! " +
                $"\n\n{name} is a {personality} hamster. {name} {sleepQuestion} and {friendlyQuestion} other animals." +
                $"\n{name} sleeps around {sleepsHoursPerDay} hours per day!");
        }
    }
}
