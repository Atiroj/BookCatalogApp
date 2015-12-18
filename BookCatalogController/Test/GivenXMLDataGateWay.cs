using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using NUnit.Framework;
using XmlDataGateWay;

namespace BookCatalogController.Test
{
  public class GivenXMLDataGateWay
  {
    [SetUp]
    public void SetUp()
    {
      BookCatalogContext.SetDataGateWay(new XMLDataGateWayImpl());

      BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Add(new CatalogProperty("Name", "Value"));

      BookCatalogContext.BookCatalogDataGateWay.BookItems.Add(new BookItem("Name", "Value"));
    }
  }
}