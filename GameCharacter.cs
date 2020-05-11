using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_bonus_13
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public virtual string Play()
        {
          return $"{Name}; {Strength}; {Intelligence}";
        }
    }
}
