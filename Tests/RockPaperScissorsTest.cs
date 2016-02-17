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
      Object provides game keys for player 1 and 2
      object takes players choices
      object returns players choices in english format
      object returns who won, or if its a draw
      object can customize keys to play with
      settings page lets uesr change keys

    /**/
    [Fact]
    public void GetGameKeysPlayerX_ProvidesKeysToPlayWith()
    {
      RockPaperScissors rps = new RockPaperScissors();
      Dictionary<char, string> keys = new Dictionary<char, string>(){};
      keys.Add('q', "Rock");
      keys.Add('w', "Paper");
      keys.Add('e', "Scissors");
      Assert.Equal(keys, rps.GetGameKeysPlayer1());
    }
    /* EXAMPLE
    // Have a queen object that knows what coordinants its at
    [Fact]
    public void QueenAttack_ForCoordinants_SeeCoordinants()
    {
      QueenAttack queen = new QueenAttack(8, 2);
      Assert.Equal(8, queen.GetX());
      Assert.Equal(2, queen.GetY());
    }
    /**/
  }
}
