using System;

namespace Taller3dSemana4
{
    internal class Scene2 : Scenes
    {
        private Player player;
        public Scene2() : base("Cadáver ignífugo", "Luego de deambular por horas logras divisar una figura más adelante.")
        {
        }
        public override void Play()
        {
            Console.WriteLine("\n--- " + title + " ---");
            Console.WriteLine(description);
            Console.WriteLine("Encuentras un cadáver encima de una pira sin quemar");
            Console.WriteLine("1. Saquear el cadáver y recolectar madera de la pira");
            Console.WriteLine("2. Rodearlo y seguir buscando leña en otro lado");
            string option = Console.ReadLine();
            if (option == "1")
            {
                player.Life -= 5;
                Console.WriteLine("El cadaver tenía vestimenta con resistencia al fuego.");
                Console.WriteLine("No logras divisar el collar maldito.");
                Console.WriteLine($"(vida actual {player.Life})");
                Console.WriteLine("Sin enbargo, consigues 10 ramas de roble.");
                player.Madera += 10;
            }
            else
            {
                Console.WriteLine("Decides ignorar el cadáver.");
                Console.WriteLine("Sin embargo, no logras consiguir madera en este lugar.");
            }
        }
    }
}