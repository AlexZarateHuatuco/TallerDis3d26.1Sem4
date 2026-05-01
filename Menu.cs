using System;
using System.Collections.Generic;

namespace Taller3dSemana4
{
    internal class Menu
    {
        public void GameStart()
        {
            Player p = new Player();
            List<Scenes> scenes = new List<Scenes>()
            {
                new Scene1(),
                new Scene2(),
                new Scene3(),
            };
            Console.WriteLine("Se acabó la leña para la estufa.");
            Console.WriteLine("Se acerca el invierno.");
            Console.WriteLine("Por lo que necesitarás encontrar más.");
            foreach (Scenes s in scenes)
            {
                s.Play();
                Console.WriteLine("\n--- Presiona ENTER para continuar ---");
                Console.ReadLine();
                // Si muere, salir del juego
                if (p.Life <= 0)
                {
                    Console.WriteLine("FINAL MALO: No lograste salir del bosque.");
                }
                else if (p.Madera >= 30 && p.Life > 5)
                {
                    Console.WriteLine("FINAL Bueno: Lograste salir del bosque con la madera suficiente.");
                    Console.WriteLine("Podrás sobrevivir este invierno.");
                }
                else if (p.Madera >= 30 && p.Life <= 5)
                {
                    Console.WriteLine("FINAL Malo: No lograste juntar la madera suficiente.");
                    Console.WriteLine("No podrás sobrevivir este invierno.");
                }
                else
                {
                    Console.WriteLine("FINAL Neutral: Lograste juntar la madera suficiente, pero tu salud está muy baja.");
                    Console.WriteLine("Tal vez no logres salir del bosque y regresar a tu hogar.");
                }
            }
        }
    }
}