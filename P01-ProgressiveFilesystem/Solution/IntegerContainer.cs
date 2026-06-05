using System.Collections.Generic;

namespace Solution
{
  public class IntegerContainer : IntegerContainerBase
  {
    private List<int> _items = new List<int>();

    public override int Add(int value)
    {
      _items.Add(value);
      return _items.Count;
    }

    public override bool Delete(int value)
    {
      return _items.Remove(value);
    }
  }
}
