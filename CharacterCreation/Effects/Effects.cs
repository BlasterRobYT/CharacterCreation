
namespace Effects
{

    public static class EffectDatabase
    {
    public class Effect
    {
        public string Name { get; set; } = "";

        public int Power { get; set; }

        public int Duration { get; set; }
        public string Description { get; set; } = "";

    };


    public static Dictionary<string, Effect> effectList = new Dictionary<string, Effect>()
    {
        {
            "Lightning Bolt", new Effect()
            {
                Name = "Lightning Bolt",
                Power = 3,
                Duration = 1,
                Description = "The user casts a single bolt of lightning from their fingertip."
            
            }
        }

    };
        
    }



}


