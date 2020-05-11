﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_bonus_13
{
    public class Wizard : MagicCharacter
    {
        public int SpellNumber { get; set; }
        public Wizard()
        {
        }
        public override void Play()
        {
            Console.WriteLine($"Name: {Name}; Strength: {Strength}; Intelligence: {Intelligence}; Spell Number: {SpellNumber}; Magical Energy: {MagicalEnergy}");
        }
    }

}
