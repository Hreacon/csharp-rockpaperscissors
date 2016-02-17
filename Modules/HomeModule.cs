using Nancy;
using RockPaperScissorsNS.Objects;
using System.Collections.Generic;
namespace RockPaperScissorsNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        RockPaperScissors rps = new RockPaperScissors();
        return View["play.cshtml", rps];
      };
    }
  }
}
