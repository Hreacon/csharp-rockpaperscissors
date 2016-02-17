using Nancy;
using RockPaperScissorsNS.Objects;
using System.Collections.Generic;
using System;
namespace RockPaperScissorsNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        RockPaperScissors rps = RockPaperScissors.GetStoredGame();
        if(rps == null)
        {
          rps = new RockPaperScissors();
        }
        return View["play.cshtml", rps];
      };
      Get["/play/{p1}/{p2}"] = parameters => {
        RockPaperScissors rps = RockPaperScissors.GetStoredGame();

        char player1 = parameters.p1;
        char player2 = parameters.p2;

        rps.SetPlayer1Choice(player1);
        rps.SetPlayer2Choice(player2);
        return View["result.cshtml", rps];
      };
      Get["/settings"] = _ => {
        return View["settings.cshtml", RockPaperScissors.GetStoredGame()];
      };
      Post["/settings/save"] = _ => {
        string rock = Request.Form["rock"];
        Console.WriteLine(rock);
        string paper = Request.Form["paper"];
        Console.WriteLine(paper);
        string scissors = Request.Form["scissors"];
        Console.WriteLine(scissors);
        RockPaperScissors rps = RockPaperScissors.GetStoredGame();
        rps.SetRock(rock);
        rps.SetPaper(paper);
        rps.SetScissors(scissors);
        return View["play.cshtml", rps];
      };
    }
  }
}
