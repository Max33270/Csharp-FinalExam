using System; 

namespace CSharpDiscovery.Examen {
    
    public class Cleric : Character, IHealer 
    {
        public float Mana {get;set;}
        public float HealPower {get;set;} 

        public Cleric()
        {
            HealPower = 15; 
        }

        public Cleric(float Mana) :base()
        {
            Mana = 100; 
            HealPower = 15; 
        }

        public override void Special()
        {
            if (Mana + 10 <= 100) {
                Mana += 10; 
            } else {
                Mana = 100; 
            }
        }

        public override void CibledSpecial(Character myChar)
        {
            if (myChar.Health + HealPower < 100) {
                myChar.Health += HealPower; 
            }
            myChar.Health = 100; 
        }

        public override string ToString()
        {
            return Name + " : " + Health + "/" + MaxHealth + " | Classe : Clerc | Mana : " + Mana; 
        }

        public void DoubleHeal(Character myChar1, Character myChar2)
        {
            if (myChar1.Health + HealPower/2 < 100) {
                myChar1.Health += HealPower/2; 
            } else {
                myChar1.Health = 100; 
            }
            if (myChar2.Health + HealPower/2 < 100) {
                myChar2.Health += HealPower/2; 

            } else {
                myChar2.Health = 100; 
            }
        }
    }
}
