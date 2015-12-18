using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.Usecase;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class RemoveBookCatalogPropertyUsercaseTester : GivenBookCatalogPropertyContextTester
  {
    private RemoveBookCatalogPropertyUsecase _usecase;

    [SetUp]
    public new void SetUp()
    {
      _usecase = new RemoveBookCatalogPropertyUsecase();
    }

    [Test]
    public void RemoveFirstProperty()
    {
      var propertyCount = BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Count;

      var request = new RemoveBookCatalogPropertyRequestModelImpl(0);
      _usecase.Execute(request);

      Assert.AreEqual(propertyCount - 1, BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Count);
    }

    [Test]
    public void RemoveMultipleProperties()
    {
      var propertyCount = BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Count;

      var request1 = new RemoveBookCatalogPropertyRequestModelImpl(0);
      _usecase.Execute(request1);

      var request2 = new RemoveBookCatalogPropertyRequestModelImpl(1);
      _usecase.Execute(request2);

      var request3 = new RemoveBookCatalogPropertyRequestModelImpl(2);
      _usecase.Execute(request3);

      Assert.AreEqual(propertyCount - 3, BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Count);
    }
  }
}