namespace BookCatalogEditingHandler.RequestModel
{
  internal class RemoveBookItemRequestModelImpl : RemoveBookItemRequestModel
  {
    public RemoveBookItemRequestModelImpl(int index)
    {
      Index = index;
    }
    public int Index { get; set; }
  }
}