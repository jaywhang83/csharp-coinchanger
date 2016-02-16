using Nancy;
using System;
using System.Collections.Generic;
using ChangeTest;

namespace ChangeMaker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        int change;
          int.TryParse(Request.Form["cents"], out change);
          Change newChange = new Change();
          string coins = newChange.CoinChanger(change);


        return View["results.cshtml", coins];
      };
    }
  }
}
