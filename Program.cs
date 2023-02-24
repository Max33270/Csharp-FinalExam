using System; 

namespace CSharpDiscovery.Examen; 

class Program {

        static void Main(string[] str)
        {
            var cle = new Cleric();
            var cle2 = new Cleric();
            var war = new Warrior(); 
            var paladin = new Paladin();
            Console.WriteLine("---------------------------"); 

            Console.WriteLine(cle.ToString()); 
            Console.WriteLine(war.ToString());
            Console.WriteLine(paladin.ToString());

            paladin.TakeDamage(10); 
             Console.WriteLine(paladin.ToString());
           paladin.Special(); 


            Console.WriteLine(war.ToString());
            Console.WriteLine(paladin.ToString());

            

            Console.WriteLine(cle.ToString()); 
            Console.WriteLine(war.ToString());
            Console.WriteLine(paladin.ToString());

            
        }
    }
