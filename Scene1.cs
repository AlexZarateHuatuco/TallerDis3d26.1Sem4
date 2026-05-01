using System;

namespace Taller3dSemana4
{
    internal class Scene1 : Scenes
    {
        private Player player;
        public Scene1() : base("Arbol Ruinoso", "Un árbol gigantezco se eleva en el centro de un claro.")
        {
        }
        public override void Play()
        {
            Console.WriteLine("\n--- " + title + " ---");
            Console.WriteLine(description);
            Console.WriteLine("Sientes que una voz te llama hacia el árbol...");
            Console.WriteLine("1. Ir hacia el árbol");
            Console.WriteLine("2. Rodearlo y seguir buscando leña en otro lado");
            string option = Console.ReadLine();
            if (option == "1")
            {
                player.Life -= 5;
                Console.WriteLine("Una rama se enrrosca en tu brazo.");
                Console.WriteLine("Una semilla se aloja entre la carne.");
                Console.WriteLine($"(vida actual {player.Life})");
                Console.WriteLine("Sin enbargo, consigues 10 ramas de roble.");
                player.Madera += 10;
            }
            else
            {
                Console.WriteLine("Resistes al llamado y te alejas del árbol");
                Console.WriteLine("Sin embargo, no logras consig.");
            }
        }
    }
}