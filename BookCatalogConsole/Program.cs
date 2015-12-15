using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCatalogController;

namespace BookCatalogConsole
{
  public class Program
  {
    static void Main(string[] args)
    {
      string command;
      while ((command = GetCommand()) != "EXIT")
      {
        switch (command)
        {
          case "ADDPROPERTY":
            AddPropertyCommand();
            break;

          case "ADDITEM":
            AddItemCommand();
            break;

          case "MODIFYPROPERTY":
            ModifyPropertyCommand();
            break;

          case "MODIFYITEM":
            ModifyItemCommand();
            break;

          case "QUERYALLPROPERTY":
            QueryAllPropertyCommand();
            break;

          case "REMOVEPROPERTY":
            RemovePropertyCommand();
            break;

          case "REMOVEITEM":
            RemoveItemCommand();
            break;
        }
      }
    }

    private static void ShowResultOnConsole(Controller controller)
    {
      ConsolePresenter presenter = new ConsolePresenter();
      presenter.SetData(controller);
      presenter.ShowData();
    }

    private static void RemoveItemCommand()
    {
      string input = Console.ReadLine();
      var removeBookItemController = new RemoveBookItemController();
      removeBookItemController.Execute(Convert.ToInt32(input));

      ShowResultOnConsole(removeBookItemController);
    }

    private static void RemovePropertyCommand()
    {
      string input = Console.ReadLine();
      var removeBookCatalogPropertyController = new RemoveBookCatalogPropertyController();
      removeBookCatalogPropertyController.Execute(Convert.ToInt32(input));

      ShowResultOnConsole(removeBookCatalogPropertyController);
    }

    private static void QueryAllPropertyCommand()
    {
      var queryAllBookCatalogPropertiesController = new QueryAllBookCatalogPropertiesController();
      queryAllBookCatalogPropertiesController.Execute();

      ShowResultOnConsole(queryAllBookCatalogPropertiesController);
    }

    private static void ModifyItemCommand()
    {
      string input = Console.ReadLine();
      string[] inputs = input.Split(',');

      var modifyBookItemController = new ModifyBookItemController();
      modifyBookItemController.Execute(Convert.ToInt32(inputs[0]), inputs[1], inputs[2]);

      ShowResultOnConsole(modifyBookItemController);
    }

    private static void AddItemCommand()
    {
      string input = Console.ReadLine();
      string[] inputs = input.Split(',');

      var addBookCatalogPropertyController = new AddBookCatalogPropertyController();
      addBookCatalogPropertyController.Execute(inputs[0], inputs[1]);

      ShowResultOnConsole(addBookCatalogPropertyController);
    }

    private static void ModifyPropertyCommand()
    {
      string input = Console.ReadLine();
      string[] inputs = input.Split(',');

      var modifyBookCatalogPropertyController = new ModifyBookCatalogPropertyController();
      modifyBookCatalogPropertyController.Execute(Convert.ToInt32(inputs[0]), inputs[1], inputs[2]);

      ShowResultOnConsole(modifyBookCatalogPropertyController);
    }

    private static void AddPropertyCommand()
    {
      string input = Console.ReadLine();
      string[] inputs = input.Split(',');

      var addBookCatalogPropertyController = new AddBookCatalogPropertyController();
      addBookCatalogPropertyController.Execute(inputs[0], inputs[1]);

      ShowResultOnConsole(addBookCatalogPropertyController);
    }

    public static string GetCommand()
    {
      return Console.ReadLine().ToUpper();
    }
  }
}