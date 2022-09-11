using System;
using System.Collections.Generic;

namespace StrangleGame
{
  public class Game
  {
    public Game()
    {
      NumberOfAttempts = 6;
      SecretWord = "hola mundo";
      char[] charListElements = (SecretWord.ToLower()).ToCharArray();
      SecretWordChars = new List<char>(charListElements);
      GameWordChardsShow = "";
      InputCharsList = new List<char>();
      CorrectChars = new List<char>(charListElements);

      for (int i = 0; i < SecretWordChars.Count; i++)
      {
        if (SecretWordChars[i] != ' ')
        {
          SecretWordChars[i] = '_';
          GameWordChardsShow += "_ ";
        }
        else
        {
          GameWordChardsShow += "  ";
        }
      }

      DrawGameImage();

      if (NumberOfAttempts > 0)
        Console.WriteLine("Adivina la palabra: " + GameWordChardsShow);
    }

    private void DrawGameImage()
    {
      Console.WriteLine("==============================");
      Console.WriteLine($"Intentos restantes: {NumberOfAttempts}");
      Console.WriteLine("==============================");
      System.Console.WriteLine("");

      switch (NumberOfAttempts)
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
          Console.WriteLine($"GAME OVER - La palabra a adivinar era \"{SecretWord}\"");
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

    public void Play()
    {
      while (NumberOfAttempts > 0 && SecretWordChars.Contains('_'))
      {
        char inputChar = ' ';
        Console.Write("Introduce una letra: ");

        try
        {
          inputChar = Console.ReadLine().ToLower()[0];
        }
        catch (IndexOutOfRangeException)
        {
          Console.WriteLine("Debes introducir una letra");
          inputChar = '.';
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }

        if (inputChar >= 'a' && inputChar <= 'z')
        {
          if (!InputCharsList.Contains(inputChar))
          {
            Console.Clear();
            InputCharsList.Add(inputChar);
            CheckIfExistCharInSecretWord(inputChar);
            DrawGameImage();
            Console.WriteLine("Adivina la palabra: " + GameWordChardsShow);
          }
          else
          {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Ya has introducido la letra \"{inputChar}\"");
            Console.ForegroundColor = ConsoleColor.White;
          }
        }
      }

      if (!SecretWordChars.Contains('_'))
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Felicidades, has ganado!");
        Console.ForegroundColor = ConsoleColor.White;
      }
    }

    private void CheckIfExistCharInSecretWord(char inputChar)
    {
      if (CorrectChars.Contains(inputChar))
      {
        GameWordChardsShow = "";
        Console.WriteLine("Letra acertada 🚀");
        Console.WriteLine("");

        for (int i = 0; i < SecretWordChars.Count; i++)
        {
          if (CorrectChars[i] == inputChar)
          {
            SecretWordChars[i] = inputChar;
          }

          GameWordChardsShow += (SecretWordChars[i] != ' ') ? $"{SecretWordChars[i]} " : "   ";
        }
      }
      else
      {
        NumberOfAttempts--;
        Console.WriteLine("Letra incorrecta");
      }
    }

    public int NumberOfAttempts { get; set; }
    public string SecretWord { get; set; }
    public string GameWordChardsShow { get; set; }
    public List<char> InputCharsList { get; set; }
    public List<char> SecretWordChars { get; set; }
    public List<char> CorrectChars { get; set; }
  }
}