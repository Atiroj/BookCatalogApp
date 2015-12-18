using System.Configuration;
using BookCatalogController;
using BookCatalogEditingHandler.Context;
using XmlDataGateWay;
using NUnit.Framework;

namespace BookCatalogController.Test
{
  [TestFixture]
  public class RemoveBookCatalogPropertyControllerTester : GivenXMLDataGateWay
  {
    private RemoveBookCatalogPropertyController _controller;

    [SetUp]
    public void SetUp()
    {
      _controller = new RemoveBookCatalogPropertyController();
    }

    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new RemoveBookCatalogPropertyController());
    }

    [Test]
    public void CheckResponseType()
    {
      _controller.Execute("0");
      Assert.IsNotNull(_controller.ResponseModel);
    }

    
  }
}