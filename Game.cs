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

      Console.WriteLine("Adivina la palabra: " + GameWordChardsShow);
    }
    public int NumberOfAttempts { get; set; }
    public string SecretWord { get; set; }
    public string GameWordChardsShow { get; set; }
    public List<char> InputCharsList { get; set; }
    public List<char> SecretWordChars { get; set; }
    public List<char> CorrectChars { get; set; }
  }
}