using System;
using System.Collections.Generic;
using System.IO;

namespace StrangleGame
{
  public class Game
  {
    public Game()
    {
      NumberOfAttempts = 6;
      SecretWord = LoadRandomWord();
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

      Draw.GameImage(NumberOfAttempts, SecretWord);
      Draw.HideWorld(GameWordChardsShow, NumberOfAttempts);
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
            Draw.GameImage(NumberOfAttempts, SecretWord);
            Draw.HideWorld(GameWordChardsShow, NumberOfAttempts);
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

    private string LoadRandomWord()
    {
      string loadText = File.ReadAllText(@"data/sagas-miticas.txt");
      string[] words = loadText.Split('\n');
      return words[new Random().Next(0, words.Length)];
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
        Console.WriteLine("Letra incorrecta ❌");
        Console.WriteLine("");
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