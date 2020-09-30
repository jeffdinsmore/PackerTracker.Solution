using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class PackerTests : IDisposable
  {
    public void Dispose()
    {
      Packer.ClearAll();
    }

    [TestMethod]
    public void PackerConstructor_MakesPackerInstance_Packer()
    {
      Packer testPacker = new Packer("pillow", "11");
      Assert.AreEqual("pillow", testPacker.Name);
    }

    [TestMethod]
    public void GetCost_ReturnCost_IntCost()
    {
      Packer testPacker = new Packer("pillow", "11");
      Assert.AreEqual("11", testPacker.Cost);
    }
    
  }
}