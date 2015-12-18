namespace BookCatalogEditingHandler.RequestModel
{
  public interface ReadDataFileRequestModel : RequestModel
  {
    string FileName { get; }
  }
}