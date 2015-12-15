using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditingHandler.Test;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditingHandler.Test;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test.Integration
{
  [TestFixture]
  public class AddBookCatalogPropertyTester : GivenBookCatalogPropertyContextTester
  {
    [Test]
    public void TestExecute()
    {
      int previousNumber = BookCatalogContext.CatalogProperties.Count;
      var request = AddBookCatalogPropertyRequestModelFactory.Create("newName", "newValue");
      var response = (AddBookCatalogProperyResponseModel)RequestExecutor.Execute(request);
      Assert.IsTrue(response.ExecuteResult);
      Assert.AreEqual(previousNumber + 1, BookCatalogContext.CatalogProperties.Count);
    }    
  }
}