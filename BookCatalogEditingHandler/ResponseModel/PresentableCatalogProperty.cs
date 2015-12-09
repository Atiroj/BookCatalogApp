namespace BookCatalogEditingHandler.ResponseModel
{
  public class PresentableCatalogProperty
  {
    public PresentableCatalogProperty(string name, string value)
    {
      Name = name;
      Value = value;
    }

    public string Name { get; set; }
    
    public string Value { get; set; }
  }
}