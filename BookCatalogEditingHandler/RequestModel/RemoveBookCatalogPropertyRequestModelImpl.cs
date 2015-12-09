namespace BookCatalogEditingHandler.RequestModel
{
  internal class RemoveBookCatalogPropertyRequestModelImpl : RemoveBookCatalogPropertyRequestModel
  {
    public RemoveBookCatalogPropertyRequestModelImpl(int index)
    {
      Index = index;
    }

    public int Index { get; set; }
  }
}