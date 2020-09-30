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
    
    [TestMethod]
    public void GetAll_ReturnAll_NameAndCost()
    {
      Packer testPacker = new Packer("pillow", "11");

      List<Packer> result = Packer.GetAll();

      CollectionAssert.AreEqual(Packer.ListItems, result);
    }
    [TestMethod]
    public void FindItem_ReturnItemDescription_ReturnItem()
    {
      Packer testPacker = new Packer("pillow", "11");
      Packer testPacker2 = new Packer("bag", "32");

      Assert.AreEqual(testPacker2, Packer.Find(2));
    }
  }
}