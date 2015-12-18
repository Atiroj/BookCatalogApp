using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test.Integration
{
  [TestFixture]
  public class AddBookItemPropertyTester : GivenBookItemContextTester
  {
    [Test]
    public void TestExecute()
    {
      int previousNumber = BookCatalogContext.BookCatalogDataGateWay.BookItems.Count;
      var request = AddBookItemRequestModelFactory.Create("newName", "newValue");
      var response = (AddBookItemResponseModel)RequestExecutor.Execute(request);
      Assert.IsTrue(response.ExecuteResult);
      Assert.AreEqual(previousNumber + 1, BookCatalogContext.BookCatalogDataGateWay.BookItems.Count);
    }
  }
}