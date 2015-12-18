using NUnit.Framework;
using XmlDataGateWay;

namespace BookCatalogEditingHandler.Context
{
  [TestFixture]
  public class BookCatalogContextTester
  {
    [Test]
    public void TestGateWayExisting()
    {
      BookCatalogContext.SetDataGateWay(new XMLDataGateWayImpl());
      Assert.IsNotNull(BookCatalogContext.BookCatalogDataGateWay);
    }   
  }
}