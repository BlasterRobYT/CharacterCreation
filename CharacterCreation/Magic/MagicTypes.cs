

namespace Magic.MagicTypes
{

    public class MagicType
    {
        public string Type { get; set; } = "";
        public string DamageType { get; set; } = "";

        public static Dictionary<string, MagicType> allMagicTypes = new Dictionary<string, MagicType>()
        {
            {
                "Shock", new MagicType()
                {
                    Type = "Shock",
                    DamageType = "Lightning"
                }
            },
            {
            
                "Burn", new MagicType()
                {
                    Type = "Burn",
                    DamageType = "Fire"
                }

            }
        };  
   

    };
    

    
    
}