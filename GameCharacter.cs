﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_bonus_13
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public virtual void Play()
        {
            Console.WriteLine();
        }
    }
}
