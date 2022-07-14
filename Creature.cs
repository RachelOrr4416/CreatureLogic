using System;

namespace Creature
{
    public class Creature
    {

        static void Main(string[] args)
        {
            string Opener = @"            Lets build a creatue card!

            I can create one randomly or you can make choices about it.
            Please Select an option below:";
            string firstChoice = @"                    
                   1) Random Creation
            
                   2) Choose Options";
            Console.WriteLine(Opener);

            var loop = true;

            while (loop)
            {
                Console.WriteLine(firstChoice);

                var answer = Console.ReadLine();

                if (answer == "1")

                {
                    Console.WriteLine("I'll create one now, one momemnt please.");
                    CalculateCost();
                    AssignKeyword();
                    break;

                }

                if (answer == "2")
                {
                    Console.WriteLine("Okay let's see what options we have");
                    StepOne();
                    StepTwo();
                    StepThree();
                    break;

                }

                else
                {
                    Console.WriteLine("sorry I didn't get that, just type a number to make a selection");

                    loop = true;
                }
            }

        }
        public static void CalculateCost()
        {
            var castingCost = new Random();
            int cost = castingCost.Next(1, 10);
            Console.WriteLine(cost);

            int power = cost;
            int toughness = cost;

            Console.WriteLine("this creature has " + power + " power and " + toughness + " toughness");
            Console.WriteLine("this creature is a " + cost + " mana " + power + "/" + toughness);

        }

        public static void AssignKeyword()
        {

            var random = new Random();
            var list = new List<string> { "Trample", "Lifelink", "Vigilance", "Flying", "First Strike", "Double Strike", "Reach", "Indestructible", "Flash", "Haste", "Defender", "Hexproof", "Menace", "Deathtouch", "Protection" };
            int index = random.Next(list.Count);
            Console.WriteLine(list[index]);

        }

        public static void AssignRarity()
        {

        }
        public static void AssignAbilities()
        {

        }
      
        public static void StepOne()
        {

            int selectionOne;
            string chosenRarity = "no rarity";
            Console.WriteLine("Fist choose a Rarity for the card. This will determine the base points available for selecting abilities");
            string rarelist = @"
                                1) Common, 2 points
                                2) Uncommon, 4 points
                                3) Rare, 6 points
                                4) Mythic, 8 points";
            var loop = true;
            while (loop)
            {

                Console.WriteLine(rarelist);
                selectionOne = Convert.ToInt32(Console.ReadLine());
                if (selectionOne == 1)
                {
                    chosenRarity = "Common";
                    break;
                }
                if (selectionOne == 2)
                {
                    chosenRarity = "Uncommon";
                    break;
                }
                if (selectionOne == 3)
                {
                    chosenRarity = "Rare";
                    break;
                }
                if (selectionOne == 4)
                {
                    chosenRarity = "Mythic";
                    break;
                }
                else
                {
                  Console.WriteLine("please type a number to make a selection.");
                  loop = true;
                }
                
            }
            
        }

        public static void StepTwo() 
        
        {
            int selectionTwo; 
            Console.WriteLine("Choose a number 1-10. This will be the cost of the card add will grant additional points to spend on abilites.");
            selectionTwo = Convert.ToInt32(Console.ReadLine());
            
            var loop = true;
            while (loop)
            {
                if (selectionTwo >= 1 && selectionTwo <= 10)
                {
                    break;
                }
                else loop = true;

               
            }
            Console.WriteLine(selectionTwo);
        }

        public static void StepThree() 
        
        { 
        
        }
       
    }
}
