using System;

namespace BookCatalogConsole
{
  public class ConsoleView : DisplayView
  {
    public string Data { get; set; }

    public void ShowData()
    {
      Console.WriteLine(Data);
    }
  }
}