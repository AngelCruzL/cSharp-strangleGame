using System;

namespace StrangleGame
{
  public class Draw
  {
    public static void GameImage(int numberOfAttempts, string secretWord)
    {
      Console.WriteLine("==============================");
      Console.WriteLine($"Intentos restantes: {numberOfAttempts}");
      Console.WriteLine("==============================");
      System.Console.WriteLine("");

      switch (numberOfAttempts)
      {
        case 6:
          Console.WriteLine(" ---------------------");
          for (int j = 0; j <= 15; j++)
          {
            Console.WriteLine(" |");

          }
          Console.WriteLine("__________");
          break;

        case 5:
          Console.WriteLine(" ---------------------");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                  -------");
          Console.WriteLine(" |                 | -  -  |");
          Console.WriteLine(" |                 |   o   |");
          Console.WriteLine(" |                  -------");
          for (int j = 0; j <= 10; j++)
          {
            Console.WriteLine(" |");

          }
          Console.WriteLine("__________");
          break;

        case 4:
          Console.WriteLine(" ---------------------");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                  -------");
          Console.WriteLine(" |                 | -  -  |");
          Console.WriteLine(" |                 |   o   |");
          Console.WriteLine(" |                  -------");
          Console.WriteLine(" |                     |   ");
          Console.WriteLine(" |                     |   ");
          Console.WriteLine(" |                     |   ");
          Console.WriteLine(" |                     |   ");
          Console.WriteLine(" |                     |   ");
          for (int j = 0; j <= 5; j++)
          {
            Console.WriteLine(" |");

          }
          Console.WriteLine("__________");
          break;

        case 3:
          Console.WriteLine(" ---------------------");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                  -------");
          Console.WriteLine(" |                 | -  -  |");
          Console.WriteLine(" |                 |   o   |");
          Console.WriteLine(" |                  -------");
          Console.WriteLine(" |                     |   ");
          Console.WriteLine(" |                   / |   ");
          Console.WriteLine(" |                 /   |   ");
          Console.WriteLine(" |                /    |   ");
          Console.WriteLine(" |                     |   ");
          for (int j = 0; j <= 5; j++)
          {
            Console.WriteLine(" |");

          }
          Console.WriteLine("__________");
          break;

        case 2:
          Console.WriteLine(" ---------------------");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                  -------");
          Console.WriteLine(" |                 | -  -  |");
          Console.WriteLine(" |                 |   o   |");
          Console.WriteLine(" |                  -------");
          Console.WriteLine(" |                     |   ");
          Console.WriteLine(" |                   / | \\ ");
          Console.WriteLine(" |                  /  |   \\ ");
          Console.WriteLine(" |                 /   |     \\ ");
          Console.WriteLine(" |                     |   ");
          for (int j = 0; j <= 5; j++)
          {
            Console.WriteLine(" |");

          }
          Console.WriteLine("__________");
          break;

        case 1:
          Console.WriteLine(" ---------------------");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                  -------");
          Console.WriteLine(" |                 | -  -  |");
          Console.WriteLine(" |                 |   o   |");
          Console.WriteLine(" |                  -------");
          Console.WriteLine(" |                     |   ");
          Console.WriteLine(" |                   / | \\ ");
          Console.WriteLine(" |                  /  |   \\ ");
          Console.WriteLine(" |                 /   |     \\ ");
          Console.WriteLine(" |                     |   ");
          Console.WriteLine(" |                    /  ");
          Console.WriteLine(" |                   /      ");
          Console.WriteLine(" |                  /       ");
          for (int j = 0; j <= 2; j++)
          {
            Console.WriteLine(" |");

          }
          Console.WriteLine("__________");
          break;

        case 0:
          Console.WriteLine("");
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine($"GAME OVER - La palabra a adivinar era \"{secretWord}\"");
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("");
          Console.WriteLine(" ---------------------");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                     |");
          Console.WriteLine(" |                  -------");
          Console.WriteLine(" |                 | X  X  |");
          Console.WriteLine(" |                 |   o   |");
          Console.WriteLine(" |                  -------");
          Console.WriteLine(" |                     |   ");
          Console.WriteLine(" |                   / | \\ ");
          Console.WriteLine(" |                  /  |   \\ ");
          Console.WriteLine(" |                 /   |     \\ ");
          Console.WriteLine(" |                     |   ");
          Console.WriteLine(" |                    / \\");
          Console.WriteLine(" |                   /   \\  ");
          Console.WriteLine(" |                  /     \\ ");
          for (int j = 0; j <= 2; j++)
          {
            Console.WriteLine(" |");

          }
          Console.WriteLine("__________");
          break;
      }
    }

    public static void HideWorld(string hideWorld, int numberOfAttempts)
    {
      if (numberOfAttempts > 0)
        Console.WriteLine("Adivina la palabra: " + hideWorld);
    }
  }
}