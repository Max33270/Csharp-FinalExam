using System; 

namespace CSharpDiscovery.Examen {
    public interface IHealer {
        
        public float HealPower {get;set;}

        public void DoubleHeal(Character myChar1, Character myChar2); 

        public float GetHeal() {
            return HealPower; 
        }
    }

    public interface ITank {  
        public int AttackPower {get;set;}

        public void DoubleHit (Character myChar); 

        public int GetPower() {
            return AttackPower; 
        }
        
    }
}
