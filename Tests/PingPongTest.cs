using Xunit;
using PingPongApp.Objects;
using System;
using System.Collections.Generic;

namespace PingPongAppTest
{
  public class PingPongTest : IDisposable
  {
    // this will prove you can count up to numbers
    [Fact]
    public void IsPingPong_CountUp_Count()
    {
      // Arrange
      int number = 2;
      List<string> newList = new List<string> { "1", "2" };


      // Act
      List<string> result = PingPong.CountUp(number);

      // Assert
      Assert.Equal(newList, result);
    }
    // this will prove that 3s change to ping
    [Fact]
    public void IsPingPong_ChangeThree_Ping()
    {
      // Arrange
      int number = 3;
      List<string> newList = new List<string> { "1", "2", "Ping" };


      // Act
      List<string> result = PingPong.CountUp(number);

      // Assert
      Assert.Equal(newList, result);
    }
    // this will prove that 5s are changed to pongs
    [Fact]
    public void IsPingPong_ChangeFive_Pong()
    {
      // Arrange
      int number = 5;
      List<string> newList = new List<string> { "1", "2", "Ping", "4", "Pong" };


      // Act
      List<string> result = PingPong.CountUp(number);

      // Assert
      Assert.Equal(newList, result);
    }

    // this will prove that 15s are changed to ping-pongs
    [Fact]
    public void IsPingPong_ChangeFifteen_PingPong()
    {
      // Arrange
      int number = 15;
      List<string> newList = new List<string> { "1", "2", "Ping", "4", "Pong", "Ping", "7", "8", "Ping", "Pong", "11", "Ping", "13", "14", "Ping-Pong" };


      // Act
      List<string> result = PingPong.CountUp(number);

      // Assert
      Assert.Equal(newList, result);
    }



    // this will clear each test each time
    public void Dispose()
    {
      PingPong.DeleteAll();
    }
  }
}
