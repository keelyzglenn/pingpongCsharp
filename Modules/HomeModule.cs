using Nancy;
using System.Collections.Generic;
using PingPongApp.Objects;

namespace PingPongApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        var newNumber = (Request.Form["user-number"]);
        List<string> newInput = PingPong.CountUp(newNumber);
        return View["index.cshtml", newInput];
      };
    }
  }
}
