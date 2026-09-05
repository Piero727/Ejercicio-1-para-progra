using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DontDoIt : SituationBase
    {
        public override void ExecutionOfTheStory(Player player, NPC npc)
        {
            Console.WriteLine(player.name + " dice que no llevará los 2 juegos de Mario al cine");
            Console.WriteLine(npc.name + " lo entiende");
            Console.WriteLine("Al escuchar su respuesta, " + npc.name + " se despide de " + player.name + " para alistarse");

            Console.WriteLine(player.name + " se puso a pensar si comprar palomitas en el cine o hacerlas en su casa");

            Console.WriteLine("Opciones: ");
            Console.WriteLine("1.- Comprar palomitas en el cine.");
            Console.WriteLine("2.- Hacerlas en su casa.");

            bool result = int.TryParse(Console.ReadLine(), out int worth);

            while (worth > 2 || worth < 1)
            {
                Console.WriteLine("Solo puedes elegir el 1 o el 2.");
                result = int.TryParse(Console.ReadLine(), out worth);
            }

            switch (worth)
            {
                case 1:
                    BuyPopcornAtTheCinema buyPopcorn = new BuyPopcornAtTheCinema();
                    buyPopcorn.ExecutionOfTheStory(player, npc);
                    break;
                case 2:
                    MakeThemAtHome makeThem = new MakeThemAtHome();
                    makeThem.ExecutionOfTheStory(player, npc);
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }

        }
    }
}
