using BookCatalogEditingHandler.RequestModel;

namespace BookCatalogEditor.RequestModelFactory
{
  public static class ModifyBookItemRequestModelFactory
  {

    public static ModifyBookItemRequestModel Create(int index, string name, string publisher)
    {
      return new ModifyBookItemRequestModelImpl(index, name, publisher);
    }
  }
}