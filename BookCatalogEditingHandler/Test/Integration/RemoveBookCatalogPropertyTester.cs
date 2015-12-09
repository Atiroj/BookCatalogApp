using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test.Integration
{
  [TestFixture]
  public class RemoveBookCatalogPropertyTester : GivenBookCatalogPropertyContextTester
  {
    [Test]
    public void TextExecute()
    {
      int previousCount = BookCatalogContext.CatalogProperties.Count;
      var request = RemoveBookCatalogPropertyModelFactory.Create(0);
      var respond = (RemoveBookCatalogPropertyResponseModel) RequestExecutor.Execute(request);

      Assert.IsTrue(respond.ExecuteResult);
      Assert.AreEqual(previousCount -1, BookCatalogContext.CatalogProperties.Count);
    }
  }
}