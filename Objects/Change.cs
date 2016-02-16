using System;
using System.Collections.Generic;

namespace Change
{
  public class Change
  {
    public string CoinChanger(int coins)
    {
      int q = 0;
      int remainderQ = 0;

      int d = 0;
      int remainderD = 0;

      int n = 0;
      int remainderN = 0;
      if(coins >= 25)
      {
        q = coins / 25;
        remainderQ = coins % 25;
        d = remainderQ / 10;
        remainderD = remainderQ % 10;
        n = remainderD / 5;
        remainderN = remainderD % 5;
        return q + " quarter " + d + " dime " + n + " nickel " + remainderN + " penny";
      }
      if(coins > 10)
      {
        d = coins / 10;
        remainderD = coins % 10;
        n = remainderD / 5;
        remainderN = remainderD % 5;
        return d + " dime " + n + " nickel " + remainderN + " penny";
      }
      if(coins > 5)
      {
        n =  coins / 5;
         remainderN = coins % 5;

      return n + " nickel " + remainderN + " penny";
      }
      if(coins < 5)
      {
        return coins + " pennies";
      }
      return "wrong change";
    }
  }
}
