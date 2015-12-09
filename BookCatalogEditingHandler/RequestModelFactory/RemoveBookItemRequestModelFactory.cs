using BookCatalogEditingHandler.RequestModel;

namespace BookCatalogEditor.RequestModelFactory
{
  public static class RemoveBookItemRequestModelFactory
  {
    public static RemoveBookItemRequestModel Create(int index)
    {
      return new RemoveBookItemRequestModelImpl(index);
    }
  }
}