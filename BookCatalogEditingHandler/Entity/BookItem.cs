namespace BookCatalogEditingHandler.Entity
{
    public class BookItem
    {
      public BookItem(string name, string publisher)
      {
        Name = name;
        Publisher = publisher;
      }

      public string Name { get; set; }

      public string Publisher { get; set; }
    }
}