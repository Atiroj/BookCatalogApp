using BookCatalogEditingHandler.RequestModel;

namespace BookCatalogEditor.RequestModelFactory
{
  public static class AddBookCatalogPropertyRequestModelFactory
  {
    public static AddBookCatalogPropertyRequestModel Create(string name, string value)
    {
      return new AddBookCatalogPropertyRequestModelImpl(name, value);
    }
  }
}