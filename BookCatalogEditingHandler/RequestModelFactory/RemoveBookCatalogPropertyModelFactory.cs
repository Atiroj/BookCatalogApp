using BookCatalogEditingHandler.RequestModel;

namespace BookCatalogEditor.RequestModelFactory
{
  public static class RemoveBookCatalogPropertyModelFactory
  {
    public static RemoveBookCatalogPropertyRequestModel Create(int index)
    {
      return new RemoveBookCatalogPropertyRequestModelImpl(index);
    }
  }
}