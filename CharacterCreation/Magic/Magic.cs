


using Magic.MagicTypes;

namespace Magic
{

    public static class MagicDatabase
    {
    public class Magic
    {
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";

        public int Power { get; set; }

        public int Duration { get; set; }
        public string Description { get; set; } = "";

    };


    public static Dictionary<string, Magic> magicList = new Dictionary<string, Magic>()
    {
        {
            "Lightning Bolt", new Magic()
            {
                Name = "Lightning Bolt",
                Type = "Shock",
                Power = 3,
                Duration = 1,
                Description = "The user casts a single bolt of lightning from their fingertip."
            
            }
        },
        {
            "Fireball", new Magic()
            {
                Name = "Fireball",
                Type = "Fire",
                Power = 4,
                Duration = 1,
                Description = "The user fires a single ball of fire towards the enemy."

            }
        }

    };
        
    }



}


