using System; 

namespace CSharpDiscovery.Examen {
    
    public class Warrior : Character, ITank
    {
        public bool Bravery {get;set;}
        public int AttackPower {get;set;}
        public Warrior()
        {
            AttackPower = 25;
        }

        public Warrior(bool Bravery) :base()
        {
            Bravery = false; 
            AttackPower = 25; 
        }

        public override void Special()
        {
            if (Health<30) {
                Bravery = true; 
            } else {
                Bravery = false; 
            }
        }

        public override void CibledSpecial(Character myChar)
        {
            if (myChar.Health - AttackPower >= 0 && Bravery == false) {
                myChar.Health -= AttackPower;
            }
            else if (myChar.Health - 40 >= 0 && Bravery == true) {
                myChar.Health -= 40; 
            } else {
                myChar.Health = 0; 
            }
            
        }

        public override string ToString()
        {
            return Name + " : " + Health + "/" + MaxHealth + " | Classe : Guerrier | Bravoure : " + Bravery; 
        }

        public void DoubleHit(Character myChar)
        { 
            Health -= 10; 
            if (myChar.Health - AttackPower*2 >= 0) {
                myChar.Health -= AttackPower*2; 
            }
            else {
                myChar.Health = 0; 
            }
        }
    }
}