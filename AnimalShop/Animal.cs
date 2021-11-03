using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShop
{
    class Animal
    {
        public string name { get; protected set; }
        public int price { get; protected set; }
        public string personality { get; protected set; }

        public Animal(string name, int price, string personality)
        {
            this.name = name;
            this.price = price;
            this.personality = personality;
        }

        //Just an empty metod to be overridden by sub classes. To be able to use the method name later.
        public virtual void TellStory()
        {
        }
    }
}
