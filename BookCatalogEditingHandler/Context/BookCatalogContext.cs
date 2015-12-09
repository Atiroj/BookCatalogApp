using System.Collections.Generic;
using BookCatalogEditingHandler.Entity;

namespace BookCatalogEditingHandler.Context
{
  internal static class BookCatalogContext
  {
    private static readonly List<CatalogProperty> _catalogProperties = new List<CatalogProperty>();
    private static readonly List<BookItem> _bookItems = new List<BookItem>();

    public static List<CatalogProperty> CatalogProperties
    {
      get
      {
        if (_catalogProperties.Count == 0)
          InitSampleBookCatalogProperties();

        return _catalogProperties;
      }
    }

    public static List<BookItem> BookItems
    {
      get { return _bookItems; }
    }

    private static void InitSampleBookCatalogProperties()
    {
      _catalogProperties.Add(new CatalogProperty("name1", "value1"));
      _catalogProperties.Add(new CatalogProperty("name2", "value2"));
      _catalogProperties.Add(new CatalogProperty("name3", "value3"));
      _catalogProperties.Add(new CatalogProperty("name4", "value4"));
      _catalogProperties.Add(new CatalogProperty("name5", "value5"));
    }
  }
}