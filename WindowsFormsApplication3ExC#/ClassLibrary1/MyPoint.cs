using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
  public class MyPoint
  {
    private int x;
    public MyPoint() { }
    public MyPoint(int x) { this.x = x; }
    public int Sum(MyPoint temp)
    {
      return x + temp.x;
    }
  }
}
