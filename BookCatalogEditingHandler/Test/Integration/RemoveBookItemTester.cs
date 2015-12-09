using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test.Integration
{
  [TestFixture]
  public class RemoveBookItemTester : GivenBookItemContextTester
  {
    [Test]
    public void TestExecute()
    {
      int previousCount = BookCatalogContext.BookItems.Count;
      var request = RemoveBookItemRequestModelFactory.Create(0);
      var respond = (RemoveBookItemResponseModel) RequestExecutor.Execute(request);

      Assert.IsTrue(respond.ExecuteResult);
      Assert.AreEqual(previousCount -1, BookCatalogContext.BookItems.Count);
    }
  }
}