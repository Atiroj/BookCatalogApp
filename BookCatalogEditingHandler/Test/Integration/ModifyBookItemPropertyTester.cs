using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test.Integration
{
  [TestFixture]
  public class ModifyBookItemPropertyTester : GivenBookItemContextTester
  {
    [Test]
    public void TestExecute()
    {
      var request = ModifyBookItemRequestModelFactory.Create(0, "newName", "newPublisher");
      var respond = (ModifyBookItemResponseModel) RequestExecutor.Execute(request);

      Assert.IsTrue(respond.ExecuteResult);
      Assert.AreEqual(BookCatalogContext.BookCatalogDataGateWay.BookItems[0].Name, "newName");
      Assert.AreEqual(BookCatalogContext.BookCatalogDataGateWay.BookItems[0].Publisher, "newPublisher");
    }
  }
}