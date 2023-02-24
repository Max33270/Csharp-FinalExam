using System; 

namespace CSharpDiscovery.Examen {

    public class Paladin : Character, IHealer, ITank
    {
        public int Buff {get;set;}
        public float HealPower {get;set;}
        public int AttackPower {get;set;}
       

        public Paladin()
        {
            Buff = 0; 
        }
        
        public override void CibledSpecial(Character myChar)
        {
            if (myChar.Health - (AttackPower+Buff) >=0) {
                myChar.Health = myChar.Health - (AttackPower + Buff); 
                if (Buff<=12) {
                    Buff += 3; 
                }
                else {
                    Buff = 15; 
                }
            }
            else {
                myChar.Health = 0; 
            }
        }

        public override void Special()
        {
            if (Health + HealPower + Buff <= 100) {
                Health += HealPower + Buff; 
            } else {
                Health = 100; 
            }
        }

        public override string ToString()
        {
            return Name + " : " + Health + "/" + MaxHealth + " | Classe : Paladin | Buff : " + Buff; 
        }


        // Obliger d'inclure ceci sinon erreur
        public void DoubleHeal(Character myChar1, Character myChar2)
        {
            throw new NotImplementedException();
        }

        public void DoubleHit(Character myChar)
        {
            throw new NotImplementedException();
        }
    }
}
    