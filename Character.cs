using System;

namespace CSharpDiscovery.Examen { 

    public abstract class Character 
    {
        public string? Name {get;set;}
        public float Health {get;set;}
        public float MaxHealth {get;set;}
        DateTime CreationDate = DateTime.Now; 

        public Character()
        {
            Name = "NPC";
            Health =  100; 
            MaxHealth = 100; 
        }

        public Character(string name, float maxHealth)
        {
            this.Name = name; 
            this.MaxHealth = maxHealth; 
            this.Health = MaxHealth; 
        }

        public void TakeDamage (int dam) 
        {
            if (Health - dam > 0) {
                Health -= dam; 
            } else {
                Health = 0; 
            }
        }

        public string GetCreationDate() 
        {
            return  CreationDate.ToString("dd/MM HH:mm"); 
        }

        public override string ToString()
        {
            return Name + " : " + Health + "/" + MaxHealth; 
        }

       public abstract void Special(); 
        public abstract void CibledSpecial(Character myChar); 
    }
}



