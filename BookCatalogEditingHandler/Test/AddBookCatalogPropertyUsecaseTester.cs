using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.Usecase;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.Test;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class AddBookCatalogPropertyUsecaseTester : GivenBookCatalogPropertyContextTester
  {
    private AddBookCatalogPropertyUsecase _usecase;

    [SetUp]
    public new void SetUp()
    {
      _usecase = new AddBookCatalogPropertyUsecase();
    }

    
    [Test]
    public void AddNothing()
    {
      int previousNumber = BookCatalogContext.CatalogProperties.Count;
      _usecase.Execute(null);
      Assert.AreEqual(previousNumber, BookCatalogContext.CatalogProperties.Count);
    }

    [Test]
    public void AddAProperty()
    {
      int previousNumber = BookCatalogContext.CatalogProperties.Count;
      var request = new AddBookCatalogPropertyRequestModelImpl("CatalogName", "Catalog1");
      _usecase.Execute(request);
      Assert.AreEqual(previousNumber + 1, BookCatalogContext.CatalogProperties.Count);
    }
  }
}
