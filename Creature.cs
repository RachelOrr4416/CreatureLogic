using System;

namespace Creature
{
    public class Creature
    {

     static void Main(string[] args)
     {
            string Opener = @"            Lets build a creatue card!

            I can create one randomly or you can make choices about it.
            Please Select an option by typing the first word:";
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
                    Console.WriteLine("I'l create one now, one momemnt please.");
                    break;
                     
            }

                if (answer == "choose")
                {
                    Console.WriteLine("Okay let's see what options we have");
                    break;

                }

                else
                {
                    Console.WriteLine("sorry I didn't get that, lets try again");
                    
                    loop = true;
                }
            }
     }   
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /*
        public int Cost = 2;
        public int Power = 2;
        public int Toughness = 2;
        public string CreatueType = "Dragon";
        public string Rarity = "Mythic";
        public string Abilites = "Flying Haste";
       

        static void Main(string[] args)
        {


            Console.WriteLine("This creature is a " + Rarity + " Dragon for 4RR with Flying Haste and has 6 and toughness 6");

            
        }
      
        
      
        /*  public int power = 0;
        public int toughness = 0;
        public string KeywordAbility = "Word"; 
        public string Downside = "Bad Card Effects";
        public string Upside = "Good Card Effects";
        public string Rarity = "Determines the points available for the creature";
        public int Cost= 0; //the mana value and color
        public string Color = "The cards color"; //defines the keywords available
        public string Legendary = "This is a random upside"; //more points and doesn't require downsides
        public decimal? PointValue= 0; // will determine how many downsides/upsides
        public string Type = "Dragon";

        */
        
        

            
    }
}
