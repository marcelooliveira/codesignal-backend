using Xunit;

namespace Solution.Tests
{
  /// <summary>
  /// The test class below includes 10 tests for Level 1.
  ///
  /// All have the same score.
  /// You are not allowed to modify this file, but feel free to read the source code to better understand what is happening in every specific case.
  /// </summary>
  [Collection("Level1Tests")]
  [TestCaseOrderer("Solution.Tests.Orderers.AlphabeticalOrderer", "Solution.Tests")]
  public class Level1Tests
  {

    private IntegerContainerBase _container;

    public Level1Tests()
    {
      _container = new IntegerContainer();
    }

    [Fact(DisplayName = "Test level 1 case 01 add two numbers")]
    public void TestLevel1Case01AddTwoNumbers()
    {
      Utility.CheckTimeout(() => {
        Assert.Equal(1, _container.Add(10));
        Assert.Equal(2, _container.Add(100));
      }, 200);
    }

    [Fact(DisplayName = "Test level 1 case 02 add many numbers")]
    public void TestLevel1Case02AddManyNumbers()
    {
      Utility.CheckTimeout(() => {
        Assert.Equal(1, _container.Add(10));
        Assert.Equal(2, _container.Add(9));
        Assert.Equal(3, _container.Add(8));
        Assert.Equal(4, _container.Add(7));
        Assert.Equal(5, _container.Add(6));
        Assert.Equal(6, _container.Add(5));
        Assert.Equal(7, _container.Add(4));
        Assert.Equal(8, _container.Add(3));
        Assert.Equal(9, _container.Add(2));
        Assert.Equal(10, _container.Add(1));
      }, 200);
    }

    [Fact(DisplayName = "Test level 1 case 03 delete number")]
    public void TestLevel1Case03DeleteNumber()
    {
      Utility.CheckTimeout(() => {
        Assert.Equal(1, _container.Add(10));
        Assert.Equal(2, _container.Add(100));
        Assert.True(_container.Delete(10));
      }, 200);
    }

    [Fact(DisplayName = "Test level 1 case 04 delete nonexisting number")]
    public void TestLevel1Case04DeleteNonexistingNumber()
    {
      Utility.CheckTimeout(() => {
        Assert.Equal(1, _container.Add(10));
        Assert.Equal(2, _container.Add(100));
        Assert.False(_container.Delete(20));
        Assert.True(_container.Delete(10));
        Assert.False(_container.Delete(10));
      }, 200);
    }

    [Fact(DisplayName = "Test level 1 case 05 add and delete same numbers")]
    public void TestLevel1Case05AddAndDeleteSameNumbers()
    {
      Utility.CheckTimeout(() => {
        Assert.Equal(1, _container.Add(10));
        Assert.Equal(2, _container.Add(10));
        Assert.Equal(3, _container.Add(10));
        Assert.Equal(4, _container.Add(10));
        Assert.Equal(5, _container.Add(10));
        Assert.True(_container.Delete(10));
        Assert.True(_container.Delete(10));
        Assert.True(_container.Delete(10));
        Assert.True(_container.Delete(10));
        Assert.True(_container.Delete(10));
        Assert.False(_container.Delete(10));
        Assert.False(_container.Delete(10));
      }, 200);
    }

    [Fact(DisplayName = "Test level 1 case 06 add delete several times")]
    public void TestLevel1Case06AddDeleteSeveralTimes()
    {
      Utility.CheckTimeout(() => {
        Assert.Equal(1, _container.Add(555));
        Assert.True(_container.Delete(555));
        Assert.False(_container.Delete(555));
        Assert.Equal(1, _container.Add(555));
        Assert.True(_container.Delete(555));
        Assert.False(_container.Delete(555));
      }, 200);
    }

    [Fact(DisplayName = "Test level 1 case 07 delete in random order")]
    public void TestLevel1Case07DeleteInRandomOrder()
    {
      Utility.CheckTimeout(() => {
        Assert.Equal(1, _container.Add(10));
        Assert.Equal(2, _container.Add(20));
        Assert.Equal(3, _container.Add(30));
        Assert.Equal(4, _container.Add(40));
        Assert.Equal(5, _container.Add(40));
        Assert.True(_container.Delete(30));
        Assert.False(_container.Delete(30));
        Assert.True(_container.Delete(10));
        Assert.False(_container.Delete(10));
        Assert.True(_container.Delete(40));
        Assert.True(_container.Delete(40));
        Assert.False(_container.Delete(40));
        Assert.True(_container.Delete(20));
        Assert.False(_container.Delete(20));
      }, 200);
    }

    [Fact(DisplayName = "Test level 1 case 08 delete before add")]
    public void TestLevel1Case08DeleteBeforeAdd()
    {
      Utility.CheckTimeout(() => {
        Assert.False(_container.Delete(1));
        Assert.False(_container.Delete(2));
        Assert.False(_container.Delete(3));
        Assert.Equal(1, _container.Add(1));
        Assert.Equal(2, _container.Add(2));
        Assert.Equal(3, _container.Add(3));
        Assert.True(_container.Delete(3));
        Assert.True(_container.Delete(2));
        Assert.True(_container.Delete(1));
        Assert.False(_container.Delete(3));
        Assert.False(_container.Delete(2));
        Assert.False(_container.Delete(1));
      }, 200);
    }

    [Fact(DisplayName = "Test level 1 case 09 mixed operation 1")]
    public void TestLevel1Case09MixedOperation1()
    {
      Utility.CheckTimeout(() => {
        Assert.Equal(1, _container.Add(10));
        Assert.Equal(2, _container.Add(15));
        Assert.Equal(3, _container.Add(20));
        Assert.Equal(4, _container.Add(10));
        Assert.Equal(5, _container.Add(5));
        Assert.True(_container.Delete(15));
        Assert.True(_container.Delete(20));
        Assert.False(_container.Delete(20));
        Assert.False(_container.Delete(0));
        Assert.Equal(4, _container.Add(7));
        Assert.Equal(5, _container.Add(9));
        Assert.True(_container.Delete(7));
        Assert.True(_container.Delete(10));
        Assert.True(_container.Delete(10));
        Assert.False(_container.Delete(10));
        Assert.False(_container.Delete(100));
      }, 200);
    }

    [Fact(DisplayName = "Test level 1 case 10 mixed operation 2")]
    public void TestLevel1Case10MixedOperation2()
    {
      Utility.CheckTimeout(() => {
        Assert.False(_container.Delete(6));
        Assert.Equal(1, _container.Add(100));
        Assert.False(_container.Delete(200));
        Assert.Equal(2, _container.Add(500));
        Assert.False(_container.Delete(0));
        Assert.Equal(3, _container.Add(300));
        Assert.False(_container.Delete(1000));
        Assert.Equal(4, _container.Add(400));
        Assert.True(_container.Delete(300));
        Assert.True(_container.Delete(400));
        Assert.True(_container.Delete(100));
        Assert.True(_container.Delete(500));
        Assert.Equal(1, _container.Add(1000));
        Assert.Equal(2, _container.Add(100));
        Assert.Equal(3, _container.Add(10));
        Assert.Equal(4, _container.Add(1));
        Assert.True(_container.Delete(100));
        Assert.False(_container.Delete(500));
        Assert.False(_container.Delete(300));
        Assert.False(_container.Delete(400));
      }, 200);
    }
  }
}
