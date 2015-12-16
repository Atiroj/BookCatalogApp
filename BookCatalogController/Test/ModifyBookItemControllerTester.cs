using BookCatalogController;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditingHandler.Test;
using NUnit.Framework;

namespace BookCatalogController.Test
{
  [TestFixture]
  public class ModifyBookItemControllerTester : GivenBookItemContextTester
  {
    private ModifyBookItemController _controller;

    [SetUp]
    public void SetUp()
    {
      _controller = new ModifyBookItemController();
    }

    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new ModifyBookItemController());
    }

    [Test]
    public void CheckResponseType()
    {
      _controller.Execute("0, newName, newPublisher");
      Assert.IsNotNull(_controller.ResponseModel);
      Assert.IsTrue(_controller.ResponseModel is ModifyBookItemResponseModel);
    }
    
  }
}