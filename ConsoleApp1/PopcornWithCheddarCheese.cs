using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PopcornWithCheddarCheese : SituationBase
    {
        public override void ExecutionOfTheStory(Player player, NPC npc)
        {
            Console.WriteLine(player.name + " compra las palomitas con queso cheddar");
            Console.WriteLine("Le envía un mensaje a " + npc.name + " para avisarle qué tipo de palomitas ha elegido");
            Console.WriteLine(player.name + " se alista para salir de su casa");
            Console.WriteLine("Al estar listo, se va rumbo al cine y le deja un mensaje a " + npc.name + " avisándole que todo está listo.");
        }
    }
}
