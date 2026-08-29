using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Execute
    {
        
        public void Start()
        {
            Console.WriteLine("Introduce tu nombre");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName);
            Console.WriteLine("Inicias tu aventura");
            Console.WriteLine("Hola, nuevo viajero");
            Console.WriteLine("Como quieres que se llame este npc");
            string npcNmae = Console.ReadLine();
            Console.WriteLine("¿Cuantos años quieres que tenga este npc?");
            int npcAge = int.Parse(Console.ReadLine());


            while (npcAge < 10 || npcAge > 100)
            {
                if (npcAge < 10)
                {
                    Console.WriteLine("No puedes poner a tu npc una edad muy baja");
                    npcAge = int.Parse(Console.ReadLine());
                }


                else if (npcAge > 100)
                {
                    Console.WriteLine("No puedes poner a tu npc una edad muy avanzada");
                    npcAge = int.Parse(Console.ReadLine());
                }

            }

            NPC nPC = new NPC(npcNmae, npcAge);

            Console.WriteLine("Gracias al introducirle el nombre y la edad a tu npc.");
            Console.WriteLine(nPC.name + " con " + nPC.age + " años de edad");

            Decision();
        }

        private void Decision()
        {
            Console.WriteLine("Escoge izquierda o derecha");
            Console.WriteLine("1.- Izquierda");
            Console.WriteLine("2.- Derecha");
            int result = int.Parse(Console.ReadLine());
            while (result > 2 || result < 1)
            {
                Console.WriteLine("Solo tienes 2 opciones:");
                Console.WriteLine("1.- Izquierda");
                Console.WriteLine("2.- Derecha");
                result = int.Parse(Console.ReadLine());
            }

            if (result == 1)
            {

            }

            else if (result == 2)
            {

            }
        }
    }
}
