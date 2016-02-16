using Xunit;
using System.Collections.Generic;
using System;
namespace Change
{
  public class ChangeTest
  {
    [Fact]
    public void CoinChanger_ForPenny()
    {
      Change testCoins = new Change();
      Assert.Equal("4 pennies", testCoins.CoinChanger(4));
    }
    [Fact]
    public void CoinChanger_ForNickel()
    {
        Change testCoins = new Change();
        Assert.Equal("1 nickel 1 penny", testCoins.CoinChanger(6));
    }
    [Fact]
    public void CoinChanger_ForDime()
    {
      Change testCoins = new Change();
      Assert.Equal("1 dime 1 nickel 1 penny", testCoins.CoinChanger(16));
    }
    [Fact]
    public void CoinChanger_ForQuarter()
    {
      Change testCoins = new Change();
      Assert.Equal("1 quarter 1 dime 1 nickel 1 penny", testCoins.CoinChanger(41));
    }
  }
}
