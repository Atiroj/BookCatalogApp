using BookCatalogEditingHandler.ResponseModel;
using NUnit.Framework;

namespace BookCatalogController.Test
{
  [TestFixture]
  public class AddBookItemControllerTester : GivenXMLDataGateWay
  {
    private AddBookItemController _controller;

    [SetUp]
    public void SetUp()
    {
      _controller = new AddBookItemController();
    }

    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new AddBookItemController());
    }

    [Test]
    public void CheckResponseType()
    {
      _controller.Execute("newName, newPublisher");
      Assert.IsNotNull(_controller.ResponseModel);
      Assert.IsTrue(_controller.ResponseModel is AddBookItemResponseModel);
    }

  }
}