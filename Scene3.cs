using System;

namespace Taller3dSemana4
{
    internal class Scene3 : Scenes
    {
        private Player player;
        public Scene3() : base("Guardián Arbóreo", "con tus últimas fuerzas logras continuar hasta la entrada de un castillo en ruinas.")
        {
        }
        public override void Play()
        {
            Console.WriteLine("\n--- " + title + " ---");
            Console.WriteLine(description);
            Console.WriteLine("Encuentras un caballero de madera a la entrada de este castillo.");
            Console.WriteLine("1. Atacar al guardián y recolectar las ramas de su cuerpo.");
            Console.WriteLine("2. Mostrarle la semilla enterrada en tu mano.");
            string option = Console.ReadLine();
            if (option == "1")
            {
                player.Life -= 5;
                Console.WriteLine("Decides ignorar el cadáver.");
                Console.WriteLine("Sin embargo, no logras consiguir madera en este lugar.");
                Console.WriteLine($"(vida actual {player.Life})");
                Console.WriteLine("Sin enbargo, consigues 10 ramas de roble.");
                player.Madera += 10;
            }
            else
            {
                Console.WriteLine("El guardia reconoce que se trata de la semilla del árbol del mundo.");
                Console.WriteLine("Se convoca una asamblea real para la resurrección del Árbol del mundo.");
                Console.WriteLine("Después de una larga y agonizante cirugía se logra extirpar la semilla de tu cuerpo.");
                Console.WriteLine("Por tu ayuda a traer la semilla de vuelta, te regalan una carreta repleta de madera para el invierno.");
                Console.WriteLine("Además te muestran el camino de regreso para que no te pierdas.");
                player.Madera += 100;
                Console.WriteLine($"(madera actual {player.Madera})");
            }
        }
    }
}