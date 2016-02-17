using System.Collections.Generic;
using System;
namespace RockPaperScissorsNS.Objects
{
  public class RockPaperScissors
  {
    // initial keys
    private static Dictionary<char, string> _startKeysPlayer1 = new Dictionary<char, string>() {
      {'q', "Rock"},
      {'w', "Paper"},
      {'e', "Scissors"}
    };
    private static Dictionary<char, string> _startKeysPlayer2 = new Dictionary<char, string>() {
      {'p', "Rock"},
      {'o', "Paper"},
      {'i', "Scissors"}
    };
    private Dictionary<char,string> _keysPlayer1;
    private Dictionary<char,string> _keysPlayer2;
    private string _choicePlayer1;
    private string _choicePlayer2;

    public RockPaperScissors()
    {
      _keysPlayer1 = _startKeysPlayer1;
      _keysPlayer2 = _startKeysPlayer2;
    }

    public Dictionary<char,string> GetGameKeysPlayer1()
    {
      return _keysPlayer1;
    }
    public Dictionary<char,string> GetGameKeysPlayer2()
    {
      return _keysPlayer2;
    }

    public static Dictionary<char,string> GetOriginalGameKeysPlayer1()
    {
      return _startKeysPlayer1;
    }
    public static Dictionary<char,string> GetOriginalGameKeysPlayer2()
    {
      return _startKeysPlayer2;
    }
  } // end class
} // end namespace
