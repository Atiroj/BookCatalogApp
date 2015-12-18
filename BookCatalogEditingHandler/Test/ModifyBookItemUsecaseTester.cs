using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.Usecase;
using BookCatalogEditingHandler.Entity;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class ModifyBookItemUsecaseTester : GivenBookItemContextTester
  {
    private ModifyBookItemUsecase _usecase;

    [SetUp]
    public new void SetUp()
    {
      _usecase = new ModifyBookItemUsecase();
    }


    [Test]
    public void EditOneItem()
    {
      string name = "newBook1";
      string publisher = "XPublisher";
      var request = new ModifyBookItemRequestModelImpl(0, name, publisher);
      _usecase.Execute(request);

      Assert.AreEqual(name, BookCatalogContext.BookCatalogDataGateWay.BookItems[0].Name);
      Assert.AreEqual(publisher, BookCatalogContext.BookCatalogDataGateWay.BookItems[0].Publisher);
    }

    [Test]
    public void EditMultiItems()
    {
      string name1 = "newBook1";
      string publisher1 = "XPublisher";
      var request1 = new ModifyBookItemRequestModelImpl(0, name1, publisher1);
      _usecase.Execute(request1);

      string name2 = "newBook2";
      string publisher2 = "YPublisher";
      var request2 = new ModifyBookItemRequestModelImpl(1, name2, publisher2);
      _usecase.Execute(request2);

      Assert.AreEqual(name1, BookCatalogContext.BookCatalogDataGateWay.BookItems[0].Name);
      Assert.AreEqual(publisher1, BookCatalogContext.BookCatalogDataGateWay.BookItems[0].Publisher);
      Assert.AreEqual(name2, BookCatalogContext.BookCatalogDataGateWay.BookItems[1].Name);
      Assert.AreEqual(publisher2, BookCatalogContext.BookCatalogDataGateWay.BookItems[1].Publisher);
    }

  }


}