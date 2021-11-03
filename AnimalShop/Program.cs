using System;
using System.Collections.Generic;


namespace AnimalShop
{
    class Program
    {
        //An object of AnimalShop is created to give access to its content.
        static AnimalShop animalShop = new AnimalShop();
        public static List<Cat> catList;
        public static List<Dog> dogList;
        public static List<Hamster> hamsterList;
        static void Main(string[] args)
        {
            catList = new List<Cat>();
            catList.Add(new Cat("Tom", 2000, "impulsive", true, true, 2.0f));
            catList.Add(new Cat("Kelly", 3000, "kind", true, false, 1.55f));
            catList.Add(new Cat("Hunk", 1000, "compassionate", false, true, 1.37f));
            catList.Add(new Cat("Princess", 5000, "pure", true, false, 0.5f));
            catList.Add(new Cat("Daisy", 1500, "lively", true, true, 0.62f));

            dogList = new List<Dog>();
            dogList.Add(new Dog("Gregory", 3000, "reliable", false, true, 40f));
            dogList.Add(new Dog("Audy", 4000, "energetic", true, true, 47f));
            dogList.Add(new Dog("Lisandra", 2000, "witty", true, false, 22f));
            dogList.Add(new Dog("Finn", 1500, "sophisticated", false, true, 24f));

            hamsterList = new List<Hamster>();
            hamsterList.Add(new Hamster("Rambo", 300, "fast", true, true, 14));
            hamsterList.Add(new Hamster("Dre", 300, "cool", true, false, 13));
            hamsterList.Add(new Hamster("Coco", 300, "gluttonus", true, false, 15));
            hamsterList.Add(new Hamster("Elly", 300, "sleepy", true, true, 16));

            RunMenu();
        }
        //Loop that contains the menu logic.
        //1 Buy animal, 2 List all animals avaiable, 3 Show Animal Shops balance & 4 Exit program.
        //Trycatching the formating error
        private static void RunMenu()
        {
            try
            {
                do
                {
                    Console.Clear();
                    DisplayMenu();
                    int inputChoice = int.Parse(Console.ReadLine());
                    switch (inputChoice)
                    {
                        case 1:
                            DisplayPurchaseAnimalMenu();
                            break;
                        case 2:
                            ListAllAnimals();
                            break;
                        case 3:
                            ShowAnimalShopBalance();
                            break;
                        case 4:
                            Environment.Exit(4);
                            break;
                    }
                } while (true);
            }
            catch (FormatException)
            {
            }
            finally
            {
                RunMenu();
            }
        }

        //Method that displays the menu structure for the loop in the main method.
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to AnimalShop" +
                              "\nWhat would you like to do?" +
                              "\n\n\t1. Purchase animals" +
                              "\n\t2. View animals in stock" +
                              "\n\t3. View animal shops balance" +
                              "\n\t4. Exit" +
                              "\n\nPlease enter the number for your action: ");
        }

        //1st choice. Lets user input animal type to buy.
        //The first animal from respective animal list is bought.
        private static void DisplayPurchaseAnimalMenu()
        {
            Console.Clear();
            Console.Write("\nPlease specify the type of animal you would like to purchase, " +
                "or press \"2\" to return to the main menu: ");
            string animalType = Console.ReadLine().Trim().ToLower();
            if (animalType == "2")
            {
                DisplayMenu();
            }
            else
            {
                Animal purchasedAnimal = animalShop.SellAnimal(animalType);
                if (purchasedAnimal == null)
                {
                    Console.WriteLine("\nWe dont have that animal in stock or you typed something wrong." +
                        "\nPress a key to retry...");
                    Console.ReadKey();
                    DisplayPurchaseAnimalMenu();
                }
                else
                {
                    purchasedAnimal.TellStory();
                    WaitingForResponseKeyMessage();
                }
            }
        }

        //2nd choice. Lists all the available animals to buy.
        private static void ListAllAnimals()
        {
            Console.Clear();
            Console.WriteLine("Type \t\tName \t\tPersonality \t\tPrice" +
                "\n------------------------------------------------------------------------");
            foreach (Cat cat in catList)
            {
                Console.WriteLine("{0,-15} {1, -15} {2, -23} {3}kr",
                    cat.GetType().ToString().Remove(0, 11), cat.name, cat.personality, cat.price);

            }
            foreach (Dog dog in dogList)
            {
                Console.WriteLine("{0,-15} {1, -15} {2, -23} {3}kr",
                    dog.GetType().ToString().Remove(0, 11), dog.name, dog.personality, dog.price);
            }
            foreach (Hamster hamster in hamsterList)
            {
                Console.WriteLine("{0,-15} {1, -15} {2, -23} {3}kr",
                    hamster.GetType().ToString().Remove(0, 11), hamster.name, hamster.personality, hamster.price);
            }
            WaitingForResponseKeyMessage();
        }

        //3rd choice. Show animal shops current balance.
        private static void ShowAnimalShopBalance()
        {
            Console.Clear();
            Console.WriteLine($"\nAnimalShops current balance is {animalShop.balance}kr");
            WaitingForResponseKeyMessage();
        }

        //Simple method that gives a message waiting for user input and ReadKey().
        private static void WaitingForResponseKeyMessage()
        {
            Console.WriteLine("\nPress a button to return to the menu...");
            Console.ReadKey();
        }
    }
}
