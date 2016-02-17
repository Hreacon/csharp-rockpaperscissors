using Xunit;
using RockPaperScissorsNS.Objects;
using System.Collections.Generic;
namespace RockPaperScissorsNS
{
  public class RockPaperScissorsTest
  {
    /*
      RockPaperScissors - Let's play a game of random skill
      Constructor takes no arguments
      Object provides game keys, defaults as qwe for player 1 and poi for player 2
      Players press the provided keys and they get returned to the object and the object gets passed to the View
      Then the players can hit enter to play again which returns the the main screen
      the main screen - players hit space and a countdown appears. Press the buttons at the same time to play

      BDD:
      Tests -



      object can customize keys to play with

    /**/
    // Object provides game keys for player 1 and 2
    [Fact]
    public void GetGameKeysPlayerX_ProvidesKeysToPlayWith()
    {
      RockPaperScissors rps = new RockPaperScissors();
      Dictionary<char, string> keys1 = new Dictionary<char, string>(){};
      keys1.Add('q', "Rock");
      keys1.Add('w', "Paper");
      keys1.Add('e', "Scissors");
      Assert.Equal(keys1, rps.GetGameKeysPlayer1());
      Dictionary<char, string> keys2 = new Dictionary<char, string>() {};
      keys2.Add('p', "Rock");
      keys2.Add('o', "Paper");
      keys2.Add('i', "Scissors");
      Assert.Equal(keys2, rps.GetGameKeysPlayer2());
    }

    // object takes players choices
    // object returns players choices in english format
    [Fact]
    public void GetPlayerChoice_RockPaoerScissors()
    {
      RockPaperScissors rps = new RockPaperScissors();
      rps.SetPlayer1Choice('q');
      Assert.Equal("Rock", rps.GetPlayer1Choice());
      rps.SetPlayer2Choice('p');
      Assert.Equal("Rock", rps.GetPlayer2Choice());
    }

    // object returns who won, or if its a draw
    [Fact]
    public void GetWinner_ForPlayerChoices_PlayerXWin()
    {
      RockPaperScissors rps = new RockPaperScissors();
      rps.SetPlayer2Choice('p');
      rps.SetPlayer1Choice('q');
      Assert.Equal("Tie!", rps.GetWinner());
      rps.SetPlayer2Choice('o');
      Assert.Equal("Player 2 Wins!", rps.GetWinner());
      rps.SetPlayer1Choice('e');
      Assert.Equal("Player 1 Wins!", rps.GetWinner());
    }
  }
}
