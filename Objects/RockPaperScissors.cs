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
    private string _rock;
    private string _paper;
    private string _scissors;

    public RockPaperScissors()
    {
      _rock = "Rock";
      _paper = "Paper";
      _scissors = "Scissors";
      _startKeysPlayer1['q'] = _rock;
      _startKeysPlayer1['w'] = _paper;
      _startKeysPlayer1['e'] = _scissors;
      _startKeysPlayer2['p'] = _rock;
      _startKeysPlayer2['o'] = _paper;
      _startKeysPlayer2['i'] = _scissors;
      _keysPlayer1 = _startKeysPlayer1;
      _keysPlayer2 = _startKeysPlayer2;
    }

    public Dictionary<char,string> GetGameKeysPlayer1() { return _keysPlayer1; }
    public Dictionary<char,string> GetGameKeysPlayer2() { return _keysPlayer2; }
    public string GetRock() { return _rock; }
    public string GetPaper() { return _paper; }
    public string GetScissors() { return _scissors; }

    public void SetPlayer1Choice(char choice) { _choicePlayer1 = _keysPlayer1[choice]; }
    public string GetPlayer1Choice() { return _choicePlayer1; }
    public void SetPlayer2Choice(char choice) { _choicePlayer2 = _keysPlayer2[choice]; }
    public string GetPlayer2Choice() { return _choicePlayer2; }

    public string GetWinner()
    {
      string output = "Tie!";

      if(_choicePlayer2 == _rock)
      {
        if(_choicePlayer1 == _paper)
        {
          output = "Player 1 Wins!";
        } else if(_choicePlayer1 == _scissors)
        {
          output = "Player 2 Wins!";
        }
      } else if(_choicePlayer2 == _paper)
      {
        if(_choicePlayer1 == _rock)
        {
          output = "Player 2 Wins!";
        } else if (_choicePlayer1 == _scissors)
        {
          output = "Player 1 Wins!";
        }
      } else if (_choicePlayer2 == _scissors)
      {
        if(_choicePlayer1 == _paper)
        {
          output = "Player 2 Wins!";
        }
        else if(_choicePlayer1 == _rock)
        {
          output = "Player 1 Wins!";
        }
      }
      return output;
    }

    public static Dictionary<char,string> GetOriginalGameKeysPlayer1() { return _startKeysPlayer1; }
    public static Dictionary<char,string> GetOriginalGameKeysPlayer2() { return _startKeysPlayer2; }
  } // end class
} // end namespace
