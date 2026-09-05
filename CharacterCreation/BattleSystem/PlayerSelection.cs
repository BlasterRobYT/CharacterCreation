using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using CharacterCreation.BattleSystem.BattleSystem;
using CharacterCreation;
using CharacterCreation.Characters;
using System.Runtime.InteropServices.Marshalling;

namespace CharacterCreation.BattleSystem.PlayerSelection
{
    
    public class PlayerInput
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
                    //hero attack will go here
                }

                if (choice == "2")
                {
                    //magic selection will happen here when complete
                }
                if (choice == "3")
                {
                   //Go back to the previous prompt. 
                }
            }

        }  
    }
