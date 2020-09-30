using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;

namespace ProjectName.Tests
{
  [TestClass]
  public class NameTests
  {
    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // testing code will go here
      Name testName = new Name();
      Assert.AreEqual(true, testName.NameofMethodWeAreTesting());
    }
  }
}