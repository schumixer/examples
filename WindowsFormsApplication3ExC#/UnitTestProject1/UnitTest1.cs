using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WindowsFormsApplication3.Tests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void Sum()
    {
      MyPoint x = new MyPoint(5);
      MyPoint y = new MyPoint(2);
      int expected = 7;
      int actual = x.Sum(y);//Hello
      Assert.AreEqual(expected, actual);
    }
  }
}
