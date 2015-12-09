using BookCatalogEditingHandler.RequestModel;

namespace BookCatalogEditor.RequestModelFactory
{
  public static class ModifyBookCatalogPropertyRequestModelFactory
  {
    public static ModifyBookCatalogPropertyRequestModel Create(int index, string name, string value)
    {
      return new ModifyBookCatalogPropertyRequestModelImpl(index, name, value);
    }
  }
}