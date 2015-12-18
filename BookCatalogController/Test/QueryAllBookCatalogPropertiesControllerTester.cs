using System.Collections.Generic;
using System.Data.Common;
using BookCatalogController;
using BookCatalogController.Test;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.ResponseModel;
using NUnit.Framework;

namespace BookCatalogController
{
  [TestFixture]
  public class QueryAllBookCatalogPropertiesControllerTester : GivenXMLDataGateWay
  {
    private QueryAllBookCatalogPropertiesController _controller;

    [SetUp]
    public void SetUp()
    {
      _controller = new QueryAllBookCatalogPropertiesController();
    }

    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new QueryAllBookCatalogPropertiesController());
    }

    [Test]
    public void CheckResponseType()
    {
      _controller.Execute();
      Assert.IsNotNull(_controller.ResponseModel);
      Assert.IsTrue(_controller.ResponseModel is QueryAllCatalogPropertiesResponseModel);
    }
  }
}