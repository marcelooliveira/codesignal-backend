using System;
using System.Collections.Generic;

namespace Container
{
  public class Container : IContainer
  {
    private readonly List<int> _items = new List<int>();

    public Container() { }

    public void Add(int value)
    {
      int index = _items.BinarySearch(value);
      if (index < 0) index = ~index;
      _items.Insert(index, value);
    }

    public bool Delete(int value)
    {
      int index = _items.BinarySearch(value);
      if (index < 0) return false;
      _items.RemoveAt(index);
      return true;
    }

    public int GetMedian()
    {
      if (_items.Count == 0)
        throw new InvalidOperationException("Container is empty.");
      return _items[(_items.Count - 1) / 2];
    }
  }
}
