using BookCatalogEditingHandler.RequestModel;

namespace BookCatalogEditor.RequestModelFactory
{
  public static class AddBookItemRequestModelFactory
  {
    public static AddBookItemRequestModel Create(string name, string value)
    {
      return new AddBookItemRequestModelImpl(name, value);
    }
  }
}