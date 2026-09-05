using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BuyPopcornAtTheCinema : SituationBase
    {
        public override void ExecutionOfTheStory(Player player, NPC npc)
        {
            Console.WriteLine(player.name + " decide comprar sus palomitas usando la aplicación del cine");
            Console.WriteLine("Al entrar a la aplicación, " + player.name + " ve nuevos sabores de palomitas");
            Console.WriteLine("Opciones: ");
            Console.WriteLine("1.- Palomitas con chocolate.");
            Console.WriteLine("2.- Palomitas con queso cheddar.");
            Console.WriteLine("3.- Palomitas sabor a pizza.");


            bool result = int.TryParse(Console.ReadLine(), out int worth);

            while (worth > 3 || worth < 1)
            {
                Console.WriteLine("Solo puedes elegir el 1, el 2 o el 3");
                result = int.TryParse(Console.ReadLine(), out worth);
            }

            switch (worth)
            {
                case 1:
                    ChocolatePopcorn chocolatePopcorn = new ChocolatePopcorn();
                    chocolatePopcorn.ExecutionOfTheStory(player, npc);
                    break;

                case 2:
                    PopcornWithCheddarCheese cheddarCheese = new PopcornWithCheddarCheese();
                    cheddarCheese.ExecutionOfTheStory(player, npc);
                    break;

                case 3:
                    PizzaFlavoredPopcorn flavoredPopcorn = new PizzaFlavoredPopcorn();
                    flavoredPopcorn.ExecutionOfTheStory(player, npc);
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
