using System;

namespace StrangleGame
{
  class Program
  {
    static void Main(string[] args)
    {
      string menuOption = "";

      do
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("============ AHORCADO EN C# ============");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("");
        Console.WriteLine("Opciones:");
        Console.WriteLine("1. Jugar partida");
        Console.WriteLine("2. Información del autor");
        Console.WriteLine("3. Salir");
        Console.WriteLine("");

        Console.Write("Seleccione una opción: ");
        menuOption = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("");

        switch (menuOption)
        {
          case "1":
            Game game = new Game();
            game.Play();
            break;

          case "2":
            Console.WriteLine("Ángel Cruz (langelcruzlara@gmail.com)");
            Console.WriteLine("Software Developer");
            Console.WriteLine("GitHub: https://github.com/AngelCruzL");
            break;

          case "3":
            Console.WriteLine("Saliendo del juego...");
            break;

          default:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Opción no válida\n");
            Console.ForegroundColor = ConsoleColor.White;
            menuOption = "--";
            break;
        }
      } while (menuOption == "--");
    }
  }
}