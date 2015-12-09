using BookCatalogEditingHandler.RequestModel;

namespace BookCatalogEditor.RequestModelFactory
{
  public static class QueryAllBookCatalogPropertiesModelFactory
  {
    public static QueryAllCatalogPropertiesRequestModel Create()
    {
      return new QueryAllCatalogPropertiesRequestModelImpl();
    }
  }
}