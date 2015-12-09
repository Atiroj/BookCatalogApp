namespace BookCatalogEditingHandler.Entity
{
  public class CatalogProperty
  {
    public string Name { get; set; }
    public string Value { get; set; }

    public CatalogProperty(string name, string value)
    {
      Name = name;
      Value = value;
    }
  }
}