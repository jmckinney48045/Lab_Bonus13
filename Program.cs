using System;


namespace Lab_bonus_13
{
    class Program
    {
         
        static void Main(string[] args)
        {
            
             var warrior = new Warrior();
            
                warrior.Name = "Brutus";
                warrior.Strength = 95;
                warrior.Intelligence = 35;
                warrior.WeaponType = "Mace";
 
            var warrior2 = new Warrior();
            
                warrior2.Name = "Valkyrie";
                warrior2.Strength = 85;
                warrior2.Intelligence = 45;
                warrior2.WeaponType = "Sword";
 
            var wizard = new Wizard();
            
                wizard.Name = "Merlin";
                wizard.Strength = 65;
                wizard.Intelligence = 80;
                wizard.MagicalEnergy = 55;
                wizard.SpellNumber = 50;
            
            var wizard2 = new Wizard();
            
                wizard2.Name = "Elvira";
                wizard2.Strength = 60;
                wizard2.Intelligence = 95;
                wizard2.MagicalEnergy = 70;
                wizard2.SpellNumber = 45;
            
            var wizard3 = new Wizard();
            
                wizard3.Name = "Q";
                wizard3.Strength = 70;
                wizard3.Intelligence = 75;
                wizard3.MagicalEnergy = 80;
                wizard3.SpellNumber = 65;

            var gameCharacters = new GameCharacter[5]; { };
            gameCharacters[0] = warrior;
            gameCharacters[1] = warrior2;
            gameCharacters[2] = wizard;
            gameCharacters[3] = wizard2;
            gameCharacters[4] = wizard3;

            foreach(var character in gameCharacters)
            {
                character.Play();
            }

        }
    }
}
