using System;
using CharacterCreation;
using CharacterCreation.Weapons;

namespace CharacterCreation.Characters;

public class Character

{
    public string Name = "";
        public int Strength { get; set; }
        
        public int Health { get; set; }
        public int Intelligence { get; set; }

        public Weapon? EquippedWeapon { get; set; }

        

};             

