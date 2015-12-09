using System.Runtime.InteropServices;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.Usecase;
using NUnit.Framework;


namespace BookCatalogEditingHandler.RequestModel
{
}

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class RemoveBookItemUsecaseTester : GivenBookItemContextTester
  {
    private RemoveBookItemUsecase _usecase;
    [SetUp]
    public new void SetUp()
    {
      _usecase = new RemoveBookItemUsecase();
    }

    [Test]
    public void RemoveOneBookItem()
    {
      int previousCount = BookCatalogContext.BookItems.Count;
      var request = new RemoveBookItemRequestModelImpl(0);
      _usecase.Execute(request);
      Assert.AreEqual(previousCount - 1, BookCatalogContext.BookItems.Count);
    }

    [Test]
    public void RemoveMultiBookItems()
    {
      int previousCount = BookCatalogContext.BookItems.Count;

      var request1 = new RemoveBookItemRequestModelImpl(0);
      _usecase.Execute(request1);

      var request2 = new RemoveBookItemRequestModelImpl(1);
      _usecase.Execute(request2);

      Assert.AreEqual(previousCount - 2, BookCatalogContext.BookItems.Count);
    }

    
    
  }
}