using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EldenRing : SituationBase
    {
        public override void ExecutionOfTheStory(Player player, NPC npc)
        {
            Console.WriteLine(npc.name + " dice que nunca jugó los juegos de FromSoftware, Inc");
            Console.WriteLine(player.name + " le dice que le puede gustar la película");

            Console.WriteLine(npc.name + " dice que le dará una oportunidad a la película");

            Console.WriteLine("Al escuchar su respuesta, " + player.name + " se despide de " + npc.name + " para preparar todo para su salida al cine.");
            Console.WriteLine("Al colgar la llamada, " + player.name + " se puso a pensar si comprar palomitas en el cine o hacerlas en su casa");

            Console.WriteLine("Opciones: ");
            Console.WriteLine("1.- Comprar palomitas en el cine");
            Console.WriteLine("2.- Hacerlas en su casa");

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
