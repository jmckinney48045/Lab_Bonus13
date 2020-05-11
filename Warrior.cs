using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_bonus_13
{
    public class Warrior : GameCharacter
    {
        public Warrior()
        {
        }
        public string WeaponType { get; set; }
        public override string Play()
        {
            return $"Name: {Name}; Strength: {Strength}; Intelligence: {Intelligence}; Weapon: {WeaponType}";
        }
    }  
           
}
