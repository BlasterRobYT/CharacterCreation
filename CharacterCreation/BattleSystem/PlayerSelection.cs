using System.Dynamic;
using System.Xml.Serialization;
using CharacterCreation.BattleSystem;
namespace CharacterCreation.PlayerSelection
{
    
    public static class PlayerInput
        {


            public static void PlayerSelection1()
            {
                string choice = "";

                Console.Clear();
                Console.WriteLine("What would you like to use?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Magic");
                Console.WriteLine("3. Go Back");
                
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    BattlerSystem.HeroAttack();
                }

                if (choice == "3")
                {
                    
                }
            }

        }  
    }
