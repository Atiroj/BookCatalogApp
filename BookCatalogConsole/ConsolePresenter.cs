using System;
using BookCatalogController;

namespace BookCatalogConsole
{
  public class ConsolePresenter : Presenter
  { 
    public string PresentedData { get; set; }

    public void SetData(Controller controller)
    {
      PresentedData = controller.ControlPresenter.PresentedData;
    }

    public void ShowData()
    {
      Console.WriteLine(PresentedData);
    }

   
  }
}