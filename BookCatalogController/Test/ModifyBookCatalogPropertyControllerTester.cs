using BookCatalogEditingHandler.ResponseModel;
using NUnit.Framework;

namespace BookCatalogController.Test
{
  [TestFixture]
  public class ModifyBookCatalogPropertyControllerTester : GivenXMLDataGateWay
  {
    private ModifyBookCatalogPropertyController _controller;

    [SetUp]
    public new void SetUp()
    {
      _controller = new ModifyBookCatalogPropertyController();
    }

    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new ModifyBookCatalogPropertyController());
    }

    [Test]
    public void CheckResponseType()
    {
      _controller.Execute("0, newName, newValue");
      Assert.IsNotNull(_controller.ResponseModel);
      Assert.IsTrue(_controller.ResponseModel is ModifyBookCatalogPropertyResponseModel);
    }
  }
}