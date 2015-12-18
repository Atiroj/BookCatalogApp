using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using NUnit.Framework;
using XmlDataGateWay;

namespace BookCatalogEditingHandler.Test
{
  // [TestFixture]
  public class GivenBookItemContextTester
  {
    [SetUp]
    public void SetUp()
    {
      BookCatalogContext.SetDataGateWay(new XMLDataGateWayImpl());

      BookCatalogContext.BookCatalogDataGateWay.BookItems.Add(new BookItem("Book1", "Publisher1"));
      BookCatalogContext.BookCatalogDataGateWay.BookItems.Add(new BookItem("Book2", "Publisher2"));
      BookCatalogContext.BookCatalogDataGateWay.BookItems.Add(new BookItem("Book3", "Publisher3"));
      BookCatalogContext.BookCatalogDataGateWay.BookItems.Add(new BookItem("Book4", "Publisher4"));
      BookCatalogContext.BookCatalogDataGateWay.BookItems.Add(new BookItem("Book5", "Publisher5"));
    }

    [TearDown]
    public void TearDown()
    {
      BookCatalogContext.BookCatalogDataGateWay.BookItems.Clear();
    }
  }
}