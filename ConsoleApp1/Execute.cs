using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Execute: Beginning
    {
        
        public void Begin()
        {
            Console.WriteLine("Introduce tu nombre");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName);
            Console.WriteLine("Hola " + player.name);
            Console.WriteLine("Introduce el nombre de tu npc");
            string npcName = Console.ReadLine();
            Console.WriteLine("¿Cuántos años quieres que tenga tu npc?");

            bool result = int.TryParse(Console.ReadLine(), out int npcAge);

            while (result == false || npcAge < 10 || npcAge > 100)
            {
                if (result == false)
                {
                    Console.WriteLine("Has puesto texto en la edad de tu npc. Debe ser solo un número.");
                    result = int.TryParse(Console.ReadLine(), out npcAge);
                }
                else if (npcAge < 10)
                {
                    Console.WriteLine("No puedes poner a tu npc una edad muy baja");
                    result = int.TryParse(Console.ReadLine(), out npcAge);
                }

                else if (npcAge > 100)
                {
                    Console.WriteLine("No puedes poner a tu npc una edad muy avanzada");
                    result = int.TryParse(Console.ReadLine(), out npcAge);
                }
            }

            NPC npc = new NPC(npcName, npcAge);

            Console.WriteLine("Gracias al introducirle el nombre y la edad a tu npc.");
            Console.WriteLine(npc.name + " con " + npc.age + " años de edad");
            
            Situation situation1 = new Situation();

            situation1.ExecutionOfTheStory(player, npc);

        }
    }
}