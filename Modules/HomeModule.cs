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
        return View["header.cshtml"];
      };
    }
  }
}
