using System.Runtime.InteropServices;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test.Integration
{
  [TestFixture]
  public class ModifyBookCatalogPropertyTester : GivenBookCatalogPropertyContextTester
  {
    [Test]
    public void TestExecute()
    {
      var request = ModifyBookCatalogPropertyRequestModelFactory.Create(0, "newName", "newValue");
      var respond = (ModifyBookCatalogPropertyResponseModel)RequestExecutor.Execute(request);

      Assert.IsTrue(respond.ExecuteResult);
      Assert.AreEqual(BookCatalogContext.CatalogProperties[0].Name, "newName");
      Assert.AreEqual(BookCatalogContext.CatalogProperties[0].Value, "newValue");
    } 
  }
}