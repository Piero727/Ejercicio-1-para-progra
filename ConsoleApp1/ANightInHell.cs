using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ANightInHell : SituationBase
    {
        public override void ExecutionOfTheStory(Player player, NPC npc)
        {
            Func<bool> underAge = () => npc.age < 18;
            if (underAge())
            {
                Console.WriteLine(npc.name + " le dice a " + player.name + " que no puede verla por su edad");
                Console.WriteLine("Opciones: ");
                Console.WriteLine("1.- Super Mario bros 2.");
                Console.WriteLine("2.- Elden Ring.");

                bool result = int.TryParse(Console.ReadLine(), out int worth);

                while ( worth > 2 || worth < 1)
                {
                    Console.WriteLine("Solo puedes elegir el 1 o el 2.");
                    result = int.TryParse(Console.ReadLine(), out worth);
                }

                switch (worth)
                {
                    case 1:
                        SuperMario superMario = new SuperMario();
                        superMario.ExecutionOfTheStory(player, npc);
                        break;

                    case 2:
                        EldenRing eldenRing = new EldenRing();
                        eldenRing.ExecutionOfTheStory(player, npc);
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }

            else
            {
                Console.WriteLine(npc.name + " dice que le gusta la idea de ver esa película ya que es mayor de edad");
                Console.WriteLine("Al escuchar su respuesta, " + player.name + " se despide de " + npc.name + " para prepararse para su salida al cine.");

                Console.WriteLine("Al colgar la llamada " + player.name + " se puso a pensar si comprar palomitas en el cine o hacerlas en su casa");

                Console.WriteLine("Opciones: ");
                Console.WriteLine("1.- Comprar palomitas en el cine");
                Console.WriteLine("2.- Hacerlas en su casa");

                bool result = int.TryParse(Console.ReadLine(), out int worth);

                while ( worth > 2 || worth < 1)
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
}
