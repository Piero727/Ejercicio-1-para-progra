using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MakeThemAtHome : SituationBase
    {
        public override void ExecutionOfTheStory(Player player, NPC npc)
        {
            Console.WriteLine(player.name + " dice que irá a la tienda a comprar palomitas");
            Console.WriteLine("Al entrar a la tienda, compra 1kg de palomitas");
            Console.WriteLine("Al tener su pedido en sus manos regresa a su casita");
            Console.WriteLine(player.name + " llega a su casa y prepara las palomitas");

            Console.WriteLine("Al tener listo sus palomitas y las de " + npc.name + " las guarda en su mochila");
            List<string> backpack = new List<string>();
            backpack.Add("Bolsa de palomitas grande para " + player.name);
            backpack.Add("Bolsa de palomitas extra grande para " + npc.name);
            foreach (string item in backpack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Al estar listo, se va rumbo al cine y le deja un mensaje a " + npc.name + " avisándole que todo está listo.");
        }
    }
}
