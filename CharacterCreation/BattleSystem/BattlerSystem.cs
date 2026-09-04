using System;
using System.Runtime.CompilerServices;
using CharacterCreation;
using CharacterCreation.Characters;
using CharacterCreation.Weapons;
using CharacterCreation.PlayerSelection;




namespace CharacterCreation.BattleSystem;
public class BattlerSystem
{
    //Creating the battle system

    // Get Hero and Enemy
    public Character Hero;
    public Character Enemy;
    public Dictionary<string, Weapon> WeaponList { get; set; }

    public BattlerSystem(Character hero,Character enemy, Dictionary<string, Weapon> weapons)
    {
        Hero = hero;
        Enemy = enemy;
        WeaponList = weapons;
        
    
    }
        //Starting the Battle while loop
        public void StartBattle()
        {
        
            

        Console.Clear();
        Console.WriteLine($"The Battle between {Hero.Name} and {Enemy.Name} BEGINS!");
        WriteColored($"Press \"ENTER\" to start", ConsoleColor.DarkBlue);
        Console.WriteLine();
        Console.ReadLine();
        Console.WriteLine();
        


            
            
            while (Hero.Health > 0 && Enemy.Health > 0) 
            {
                //Ask until we get a valid choice.
                string choice = "";

                while (choice != "1" && choice != "2" && choice != "3")
                {
                    //Hero's turn
                    Console.WriteLine("Player, what would you like to do?:");
                    Console.WriteLine("1. Fight");
                    Console.WriteLine("2. Heal");
                    Console.WriteLine("3. Change Weapon");
                    Console.Write("Type Key 1, 2, or 3: ");

                    choice = Console.ReadLine();
                    



                    if (choice != "1" && choice != "2" && choice != "3")
                    {
                        WriteColored("You entered an invalid choice. Please try Again.", ConsoleColor.DarkRed);
                        Console.WriteLine();
                    }
                }//End of while loop
                    
                // Do the Action player inputs
                if (choice == "1")
                {
                   while (choice == "1")
                    PlayerInput.PlayerSelection1();
                }
                else if (choice == "2")
                {
                    Console.WriteLine();
                    HeroHeal();
                }
                /// Choice 3 - Change WEAPON
                if (choice == "3")
                {
                    Console.WriteLine();
                    ChangeWeapon();
                    Console.WriteLine("The player changes their weapon! It takes 1 turn!");
                }
                //Did the enemy die
                if (Enemy.Health <= 0)
                {
                    WriteColored(Enemy.Name, ConsoleColor.Yellow);
                    Console.WriteLine(" was bested.");
                    Console.ReadLine();
                    break;
                }                

                 //Enemy's turn
                EnemyAttack();

                // Check if the Hero died
                    if (Hero.Health <= 0)
                    {
                    Console.WriteLine($"Oh Dear! {Hero.Name} has been slain!");
                    Console.ReadKey();
                    break;
                    }

                //What happens when the Hero Health reaches 0


            }
        }
           
                //Blank line between rounds for clarity

            


    
        //The Hero Attack Method
        public void HeroAttack()
        {
            Random rng = new Random();
            //Declaring damage via Strength
            int damage = rng.Next(0, Hero.Strength + 1);
            //add damage if a weapon is equipped.
            if (Hero.EquippedWeapon != null)
            {
                damage += Hero.EquippedWeapon.Damage;

                //Do damage with weapon
                WriteColored(Hero.Name, ConsoleColor.Blue);
                Console.Write(" attacks with a ");
                WriteColored(Hero.EquippedWeapon.Name, ConsoleColor.DarkCyan);
                Console.Write(" for ");
                WriteColored($"{damage}", ConsoleColor.Red);
                Console.Write(" damage!");
                Console.WriteLine();
                WriteColored(Enemy.Name, ConsoleColor.Yellow);
                Console.Write(" now has ");
                WriteColored(Enemy.Health, ConsoleColor.Green);
                Console.Write(" health!");
                Console.WriteLine();
                WriteColored("Press \"ENTER\" to continue.", ConsoleColor.DarkBlue);
                Console.WriteLine();
                Console.ReadLine(); 
            }

            else
            {
                //Print decision and outcome.
                WriteColored(Hero.Name, ConsoleColor.Blue);
                Console.Write(" attacks for ");
                WriteColored(damage, ConsoleColor.Red);
                Console.WriteLine("!");
                WriteColored(Enemy.Name, ConsoleColor.Yellow);
                Console.Write(" now has ");
                WriteColored(Enemy.Health, ConsoleColor.Green);
                Console.Write(" health!");
                Console.WriteLine();
                WriteColored("Press \"ENTER\" to continue.", ConsoleColor.DarkBlue);
                Console.WriteLine();
                Console.ReadLine();  
            };  
               
            // Subtracting the damage from the enemy Health
            Enemy.Health -= damage;
            
            //Critical Fail response
            if (damage <= 0)
            {              
                WriteColored(Hero.Name, ConsoleColor.Blue);
                Console.WriteLine(" whiffed!");
            }
            
            if (Enemy.Health < 0)
            {
                Enemy.Health = 0;
            }
            
        }
            //Prints out the damage output and shows remaining
            //health of the enemy.

        
        
        //The Enemy Attack method
        private void EnemyAttack()
        {
            Random rng = new Random();
            //Declaring damage via Strength
            int damage = rng.Next(0, Enemy.Strength + 1);

            // Subtracting the damage from the enemy Health
            Hero.Health -= damage;

            if (Hero.Health <= 0)
            {
                Hero.Health = 0;
            }



            //Prints out the damage output and shows remaining
            //health of the enemy.
            WriteColored(Enemy.Name, ConsoleColor.Yellow);
            Console.Write(" attacks for ");
            WriteColored(damage, ConsoleColor.Red);
            Console.WriteLine("!");
            WriteColored(Hero.Name, ConsoleColor.Blue);
            Console.Write(" now has ");
            WriteColored(Hero.Health, ConsoleColor.Green);
            Console.Write(" health!");
            Console.WriteLine();
            WriteColored("Press \"ENTER\" to continue.", ConsoleColor.DarkBlue);
            Console.ReadLine();
            Console.WriteLine();
        }
        
        private void HeroHeal()
        {
            // Player can heal a random number 5 to 10
            Random rng = new Random();
            int healAmount = rng.Next(5, 11);

            Hero.Health += healAmount;

            //Healing cannot exceed Health
            if (Hero.Health > 50)
            {
                Hero.Health = 50;
            }

            if (Hero.Health >= 50)
            {
                Console.WriteLine("Can't go any higher!");
                Console.WriteLine();
            }
            
            else
            {
                WriteColored(Hero.Name, ConsoleColor.Blue);
                Console.WriteLine(" chooses to heal!");
                WriteColored(Hero.Name, ConsoleColor.Blue);
                Console.Write(" heals for ");
                WriteColored(healAmount, ConsoleColor.Green);
                Console.Write("!");
                Console.WriteLine();
                Console.ReadLine(); 
            }
        }
        public void ChangeWeapon()
        {
            Console.WriteLine("What weapon would you like to use?");
            Console.WriteLine();

            //Show all weapons with numbers
            int number = 1;
            List<string> names = new List<string>();

            foreach (var weapon in WeaponList)
            {
                Console.WriteLine($"{number}. {weapon.Key} (Damage: {weapon.Value.Damage})");
                names.Add(weapon.Key);
                number++;  
            }
                Console.WriteLine("Enter the number of the weapon:");
                string input = Console.ReadLine();
            
            if (int.TryParse(input, out int selected) && selected >= 1 && selected <=names.Count)
            {
                string chosenName = names[selected - 1];
                Hero.EquippedWeapon = WeaponList[chosenName];

                WriteColored(Hero.Name, ConsoleColor.Blue);
                Console.Write(" equipped the ");
                WriteColored(Hero.EquippedWeapon.Name, ConsoleColor.DarkCyan);
                Console.WriteLine("!");
            }
            else
            {
                Console.WriteLine("That's not a choice. Enter a valid choice!");
            }



        }

            //Change text to color for better readability during battle
            static void WriteColored(string text, ConsoleColor color)
            {
                Console.ForegroundColor = color;
                Console.Write(text);
                Console.ResetColor();
            }

            //Convert Int to String to display as color for better readability
            static void WriteColored(int number, ConsoleColor color)
            {
                WriteColored(number.ToString(), color);
            }



    
};