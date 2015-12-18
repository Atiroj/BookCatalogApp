using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.Usecase;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class AddBookItemUsecaseTester
  {
    private AddBookItemUsecase _usecase;

    [SetUp]
    public void Setup()
    {
      _usecase = new AddBookItemUsecase();
    }

    [Test]
    public void AddNothing()
    {
      int previousCount = BookCatalogContext.BookCatalogDataGateWay.BookItems.Count;
      _usecase.Execute(null);
      Assert.AreEqual(previousCount, BookCatalogContext.BookCatalogDataGateWay.BookItems.Count);
    }

    [Test]
    public void AddOneBookItem()
    {
      int previousCount = BookCatalogContext.BookCatalogDataGateWay.BookItems.Count;
      string name = "newBook1";
      string publisher = "McGrownHell";
      var item = new BookItem(name, publisher);
      var request = new AddBookItemRequestModelImpl(name, publisher);
      _usecase.Execute(request);
      Assert.AreEqual(previousCount + 1, BookCatalogContext.BookCatalogDataGateWay.BookItems.Count);
      Assert.AreEqual(name, BookCatalogContext.BookCatalogDataGateWay.BookItems[0].Name);
      Assert.AreEqual(publisher, BookCatalogContext.BookCatalogDataGateWay.BookItems[0].Publisher);
    }

    [Test]
    public void AddMultiBookItem()
    {
      int previousCount = BookCatalogContext.BookCatalogDataGateWay.BookItems.Count;
      string name1 = "newBook1";
      string publisher1 = "McGrownHell";
      var request1 = new AddBookItemRequestModelImpl(name1, publisher1);
      _usecase.Execute(request1);

      string name2 = "350";
      string publisher2 = "Oxford";
      var request2 = new AddBookItemRequestModelImpl(name2, publisher2);
      _usecase.Execute(request2);

      Assert.AreEqual(previousCount + 2, BookCatalogContext.BookCatalogDataGateWay.BookItems.Count);
      Assert.AreEqual(name1, BookCatalogContext.BookCatalogDataGateWay.BookItems[0].Name);
      Assert.AreEqual(publisher1, BookCatalogContext.BookCatalogDataGateWay.BookItems[0].Publisher);
      Assert.AreEqual(name2, BookCatalogContext.BookCatalogDataGateWay.BookItems[1].Name);
      Assert.AreEqual(publisher2, BookCatalogContext.BookCatalogDataGateWay.BookItems[1].Publisher);
    }
  }



}