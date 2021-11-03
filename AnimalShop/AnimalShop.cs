using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShop
{
    class AnimalShop
    {
        public int balance { get; private set; }
        private Random random = new Random();

        //If the user typed an animal type that exists and that animal is in stock,
        //a random animal of that type will be bought and that animal will be removed form the list.
        //The price is added to the property "balance".
        //That purchased animal will be returned from method or null in case not in stock.
        public Animal SellAnimal(string animalType)
        {
            if (animalType == "cat" && Program.catList.Count != 0)
            {
                int lengthOfList = Program.catList.Count;
                int randomizedIndex = AnimalRandomizer(lengthOfList);
                Cat purchasedAnimal = Program.catList[randomizedIndex];
                Program.catList.RemoveAt(randomizedIndex);
                AddToBalance(purchasedAnimal.price);
                return purchasedAnimal;
            }
            if (animalType == "dog" && Program.dogList.Count != 0)
            {
                int lengthOfList = Program.dogList.Count;
                int randomizedIndex = AnimalRandomizer(lengthOfList);
                Dog purchasedAnimal = Program.dogList[randomizedIndex];
                Program.dogList.RemoveAt(randomizedIndex);
                AddToBalance(purchasedAnimal.price);
                return purchasedAnimal;
            }
            if (animalType == "hamster" && Program.hamsterList.Count != 0)
            {
                int lengthOfList = Program.hamsterList.Count;
                int randomizedIndex = AnimalRandomizer(lengthOfList);
                Hamster purchasedAnimal = Program.hamsterList[randomizedIndex];
                Program.hamsterList.RemoveAt(randomizedIndex);
                AddToBalance(purchasedAnimal.price);
                return purchasedAnimal;
            }
            return null;
        }
        private int AnimalRandomizer(int returnedIndex)
        {
            return random.Next(0, returnedIndex);
        }
        private void AddToBalance(int priceOfAnimal)
        {
            balance += priceOfAnimal;
        }
    }
}
