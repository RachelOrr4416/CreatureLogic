using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creature
{
    //determine the point value the card will have for the other classes to work with
     public class GenerateRarity
    {
        public GenerateRarity()
        {
            
            var randomGenerator = new Random();
            var range = randomGenerator.Next(1, 101);
            string rarity;
            

            if (range <= 40)
            {
               rarity = "Common";
            }
            else if (range is >= 41 and <= 70)
            {
                rarity = "uncommon";
            }
            else if (range is >= 71 and <= 90)
            { 
                rarity = "Rare"; 
            }
            else if (range is >= 91 and <= 101)
            { 
                rarity = "Mythic"; 
            }



        }
       
    }
    
    
}
