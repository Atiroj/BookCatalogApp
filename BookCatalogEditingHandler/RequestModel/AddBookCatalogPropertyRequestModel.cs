namespace BookCatalogEditingHandler.RequestModel
{
  public interface AddBookCatalogPropertyRequestModel : RequestModel
  {
    string Name { get; }
    string Value { get; }
  }
}