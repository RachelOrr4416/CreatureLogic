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
                    random creation
            
                    choose options";
            Console.WriteLine(Opener);
            
            var loop = true;
            
            while(loop)
            {
            Console.WriteLine(firstChoice);
            
            var answer = Console.ReadLine();

            if (answer == "random")

            {
                    Console.WriteLine("I'll create one now, one momemnt please.");
                    CalculateCost();
                    AssignKeyword();
                    break;

                }

                if (answer == "choose")
                {
                    Console.WriteLine("Okay let's see what options we have");
                    
                    break;

                }

                else
                {
                    Console.WriteLine("sorry I didn't get that, just type the first word of your selection");
                    
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
           
        
    }
}
