using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bring2Games : SituationBase
    {
        public override void ExecutionOfTheStory(Player player, NPC npc)
        {
            List<string> backpack = new List<string>();
            Console.WriteLine(player.name +" decide usar la oferta");
            Console.WriteLine(player.name + " elige Super Mario 3 y Super Mario Galaxy 2");
            Console.WriteLine(player.name + " lo guarda en su mochila");
            backpack.Add("Super Mario 3");
            backpack.Add("Super Mario Galaxy 2");

            foreach (string item in backpack)
            {
                Console.WriteLine(item + " guardado");
            }

            Console.WriteLine("Al escuchar la noticia, " + npc.name + " se pone feliz y se despide de " + player.name + " para alistarse también");

            Console.WriteLine(player.name + " se puso a pensar si comprar palomitas en el cine o hacerlas en su casa");

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
