using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Situation : SituationBase
    {
        public override void ExecutionOfTheStory(Player player, NPC npc)
        {
            Console.WriteLine(player.name + " usa su celular para llamar a " + npc.name + " y preguntarle si quiere ir al cine");
            Console.WriteLine(npc.name + " acepta la invitación de " + player.name);
            Console.WriteLine(npc.name + " le pregunta qué película van a ver");
            Console.WriteLine(player.name + " usa su aplicación para ver qué películas están en la cartelera");
            Console.WriteLine("Opciones:");
            Console.WriteLine("1.- Super Mario bros 2.");
            Console.WriteLine("2.- Elden Ring.");
            Console.WriteLine("3.- Una noche en el infierno.");

            bool result = int.TryParse(Console.ReadLine(), out int worth);
            
            while(result == false || worth >3 || worth <1)
            {
                Console.WriteLine("Solo puedes elegir el 1, el 2 o el 3.");
                result = int.TryParse(Console.ReadLine(), out worth);
            }

            switch(worth)
            {
                case 1:
                    SuperMario superMario = new SuperMario();
                    superMario.ExecutionOfTheStory(player, npc);

                    break;

                case 2:
                    EldenRing eldenRing = new EldenRing();
                    eldenRing.ExecutionOfTheStory(player, npc);

                    break;

                case 3:
                    ANightInHell aNightInHell = new ANightInHell();
                    aNightInHell.ExecutionOfTheStory(player, npc);

                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
    }
}