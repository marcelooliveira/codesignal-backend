using System.Collections.Generic;
using System.Linq;
using Xunit.Abstractions;
using Xunit.Sdk;
using Xunit;

[assembly: CollectionBehavior(MaxParallelThreads = 1)]
[assembly: TestCollectionOrderer(
  "Container.Tests.Orderers.DisplayNameOrderer",
  "Container.Tests"
)]

namespace Container.Tests.Orderers
{
  public class AlphabeticalOrderer : ITestCaseOrderer
  {
    public IEnumerable<TTestCase> OrderTestCases<TTestCase>(
      IEnumerable<TTestCase> testCases) where TTestCase : ITestCase =>
      testCases.OrderBy(testCase => testCase.TestMethod.Method.Name);
  }

  public class DisplayNameOrderer : ITestCollectionOrderer
  {
    public IEnumerable<ITestCollection> OrderTestCollections(
      IEnumerable<ITestCollection> testCollections) =>
      testCollections.OrderBy(collection => collection.DisplayName);
  }
}
