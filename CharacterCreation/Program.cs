using System;
using CharacterCreation.Characters;
using CharacterCreation.BattleSystem.BattleSystem;
using CharacterCreation.BattleSystem.PlayerSelection;
using CharacterCreation.Weapons;
using Items;
using ArmorSets;




namespace CharacterCreation
{




    public class Program
    {

        public static void Main()
        {


                Dictionary<string, Weapon> weaponList = new Dictionary<string, Weapon>()
            {
                {

                    "Sword", new Weapon()
                    {
                        Name = "Sword",
                        Damage = 5,
                        Description = "A sharp steel blade."
                    }

                },
                {

                    "Axe", new Weapon()
                    {
                        Name = "Axe",
                        Damage = 7,
                        Description = "Heavy and sharp."
                    }
                },
                {
                    "Bow", new Weapon()
                    {
                        Name = "Bow",
                        Damage = 3,
                        Description = "A long bow, seems a bit worn."
                    }
                },
                {
                    "Mage Staff", new Weapon()
                    {
                        Name = "Mage Staff",
                        Damage = 6,
                        Description = "A wooden stick that resembles a branch but glows at the tip."
                    }
                }
            };

                //Defining each Item
            Dictionary<string, Item> itemList = new Dictionary<string, Item>()
            {
                {
                    "Health Potion", new Item()
                    {
                        Name = "Health Potion",
                        Description = "An elixir of life!"
                    }
                },
                {
                    "Mana Potion", new Item()
                    {
                        Name = "Health Potion",
                        Description = "An exlir for a magic user."
                    }            
                }
            };
                //Defining each piece of Armor
            Dictionary<string, Armor> armorList = new Dictionary<string, Armor>()
            {
                {
                    "Leather Cuirass", new Armor()
                    {
                        Name = "Leather Cuirass",
                        Defence = 4,
                        Description = "A sturdy curaiss made from worn leather."
                    }
                },
                {
                    "Iron Helmet", new Armor()
                    {
                        Name = "Iron Helmet",
                        Defence = 2,
                        Description = "A helmet forged from iron."
                    }
                }
            };
                                    //Defining each weapon
           
                    //The instanced Character Hero
            Character hero = new Character()
            {
                Name = "Heimdall",
                Strength = 9,
                Health = 50,
                Intelligence = 5,
                EquippedWeapon = weaponList["Sword"]
            };
        

            // The instanced Character Enemy

            Character enemy = new Character()
            {
                Name = "Goblin Peon",
                Strength = 3,
                Health = 25,
                Intelligence = 2,
                EquippedWeapon = null
            }; 


            //Start the Battle System

            BattleSystem.BattleSystem.BattleSystem battle = new BattleSystem.BattleSystem.BattleSystem(hero, enemy, weaponList);
            battle.StartBattle();
        }
        
            
        
    }
}