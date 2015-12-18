using System.Linq.Expressions;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test.Integration
{
  [TestFixture]
  public class QueryAllBookCatalogPropertiesTester : GivenBookCatalogPropertyContextTester
  {
    [Test]
    public void TestExecute()
    {
      var request = QueryAllBookCatalogPropertiesModelFactory.Create();
      var respond = (QueryAllCatalogPropertiesResponseModel) RequestExecutor.Execute(request);

      Assert.IsTrue(respond.ExecuteResult);
      AssertQueryAllBookCatalogResult(respond);   
    }

    public void AssertQueryAllBookCatalogResult(QueryAllCatalogPropertiesResponseModel responseModel)
    {
      Assert.AreEqual(responseModel.PresentableCatalogProperties.Count, BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Count);

      for (int index = 0; index < responseModel.PresentableCatalogProperties.Count; index++)
      {
        Assert.AreEqual(responseModel.PresentableCatalogProperties[index].Name, BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties[index].Name);
        Assert.AreEqual(responseModel.PresentableCatalogProperties[index].Value, BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties[index].Value);

      }
    }
  }
}