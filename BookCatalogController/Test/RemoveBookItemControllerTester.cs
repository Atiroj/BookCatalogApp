using BookCatalogController;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Test;
using NUnit.Framework;

namespace BookCatalogController.Test
{
  [TestFixture]
  public class RemoveBookItemControllerTester : GivenBookItemContextTester
  {
    private RemoveBookItemController _controller;

    [SetUp]
    public void SetUp()
    {
      _controller = new RemoveBookItemController();
    }

    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new RemoveBookItemController());
    }

    [Test]
    public void CheckResponseType()
    {
      _controller.Execute("0");
      Assert.IsNotNull(_controller.ResponseModel);
    }    
  }
}