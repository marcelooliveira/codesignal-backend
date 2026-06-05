namespace Solution
{
  /// <summary>
  /// `IntegerContainer` interface.
  /// </summary>
  public abstract class IntegerContainerBase
  {

    /// <summary>
    /// Should add the specified integer `value` to the container
    /// and return the number of integers in the container after the
    /// addition.
    /// </summary>
    public virtual int Add(int value) {
      // default implementation
      return 0;
    }

    /// <summary>
    /// Should attempt to remove the specified integer `value` from
    /// the container.
    /// If the `value` is present in the container, remove it and
    /// return `true`, otherwise, return `false`.
    /// </summary>
    public virtual bool Delete(int value) {
      // default implementation
      return false;
    }
  }
}
