using System;
using System.Threading.Tasks;

namespace Solution
{
  public static class Utility
  {
    public static void CheckTimeout(Action func, int timeInMilliseconds)
    {
      Task task = Task.Run(func);
      bool completedInTime = false;
      try
      {
        completedInTime = task.Wait(TimeSpan.FromMilliseconds(timeInMilliseconds));
      }
      catch
      {
        throw task.Exception.InnerExceptions[0];
      }

      if (!completedInTime)
      {
        throw new TimeoutException(
          "The method failed to execute within a timeout of " + timeInMilliseconds.ToString() + "ms"
        );
      }
    }
  }
}
