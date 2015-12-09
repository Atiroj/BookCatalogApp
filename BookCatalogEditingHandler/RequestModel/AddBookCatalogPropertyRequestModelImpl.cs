namespace BookCatalogEditingHandler.RequestModel
{
  internal class AddBookCatalogPropertyRequestModelImpl : AddBookCatalogPropertyRequestModel
  {
    public AddBookCatalogPropertyRequestModelImpl(string name, string value)
    {
      Name = name;
      Value = value;
    }

    public string  Name { get; set; }

    public string Value { get; set; }
  }
}