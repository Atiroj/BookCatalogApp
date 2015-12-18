using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using NUnit.Framework;
using XmlDataGateWay;

namespace BookCatalogEditingHandler.Test
{
  //[TestFixture]
  public class GivenBookCatalogPropertyContextTester
  {
    [SetUp]
    public void SetUp()
    {

      BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Add(new CatalogProperty("name1", "value1"));
      BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Add(new CatalogProperty("name2", "value2"));
      BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Add(new CatalogProperty("name3", "value3"));
      BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Add(new CatalogProperty("name4", "value4"));
      BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Add(new CatalogProperty("name5", "value5"));
    }

    [TearDown]
    public void TearDown()
    {
      BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Clear();
    }
  }
}