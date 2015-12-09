using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  //[TestFixture]
  public class GivenBookCatalogPropertyContextTester
  {
    [SetUp]
    public void SetUp()
    {
      BookCatalogContext.CatalogProperties.Add(new CatalogProperty("name1", "value1"));
      BookCatalogContext.CatalogProperties.Add(new CatalogProperty("name2", "value2"));
      BookCatalogContext.CatalogProperties.Add(new CatalogProperty("name3", "value3"));
      BookCatalogContext.CatalogProperties.Add(new CatalogProperty("name4", "value4"));
      BookCatalogContext.CatalogProperties.Add(new CatalogProperty("name5", "value5"));
    }

    [TearDown]
    public void TearDown()
    {
      BookCatalogContext.CatalogProperties.Clear();
    }
  }
}