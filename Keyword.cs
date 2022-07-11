namespace Creature
{
    public class Keyword
    {
        public Keyword()
        {
            
            {
                var random = new Random();
                var list = new List<string> { "Trample", "Lifelink", "Vigilance", "Flying", "First Strike", "Double Strike", "Reach", "Indestructible", "Flash", "Haste", "Defender", "Hexproof", "Menace", "Deathtouch", "Protection"};
                int index = random.Next(list.Count);
                Console.WriteLine(list[index]);
            }
        }
    }
}