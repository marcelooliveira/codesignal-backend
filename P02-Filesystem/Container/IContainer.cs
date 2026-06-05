namespace Container
{
  /// <summary>
  /// A container of integers that should support
  /// addition, removal, and search for the median integer
  /// </summary>
  public interface IContainer
  {
    /// <summary>
    /// Adds the specified value to the container
    /// </summary>
    /// <param name="value"></param>
    void Add(int value);

    /// <summary>
    /// Attempts to delete one item of the specified value from the container
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    /// true, if the value has been deleted,
    /// or false, otherwise
    /// </returns>
    bool Delete(int value);

    /// <summary>
    /// Finds the container's median integer value, which is
    /// the middle integer when the all integers are sorted in order.
    /// If the sorted array has an even length,
    /// the leftmost integer between the two middle
    /// integers should be considered as the median.
    /// </summary>
    /// <returns>the median if the array is not empty, or</returns>
    /// <throws>a runtime exception, otherwise.</throws>
    int GetMedian();
  }
}
