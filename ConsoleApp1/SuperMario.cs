using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SuperMario : SituationBase
    {
        public override void ExecutionOfTheStory(Player player, NPC npc)
        {
            Console.WriteLine(npc.name + " dice que le gusta la idea de ver Super Mario Bros 2, ya que ama sus juegos");
            Console.WriteLine(player.name + " ve una promoción especial para los fanáticos de Super Mario");
            Console.WriteLine("Si llevas 2 videojuegos de Mario al cine podrás llevarte la palomera de Yoshi");
            Console.WriteLine("Opciones:");
            Console.WriteLine("1.- Llevar 2 juegos.");
            Console.WriteLine("2.- No hacerlo.");

            bool result = int.TryParse(Console.ReadLine(), out int worth);

            while (worth > 2 || worth < 1)
            {
                Console.WriteLine("Solo puedes elegir el 1 o el 2.");
                result = int.TryParse(Console.ReadLine(), out worth);
            }

            switch (worth)
            {
                case 1:
                    Bring2Games bring2Games = new Bring2Games();
                    bring2Games.ExecutionOfTheStory(player, npc);
                    break;
                case 2:
                    DontDoIt dontDoIt = new DontDoIt();
                    dontDoIt.ExecutionOfTheStory(player, npc);
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
    }
}