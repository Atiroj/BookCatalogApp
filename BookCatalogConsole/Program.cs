using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCatalogController;
using BookCatalogEditingHandler.ResponseModel;

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

    private static void ShowData(ResponseModel responseModel)
    {
      ConsolePresenter consolePresenter = new ConsolePresenter();
      consolePresenter.ResponseModel = responseModel;
      consolePresenter.GenerateView();
    }
   
    private static void RemoveItemCommand()
    {
      string input = Console.ReadLine();
      var removeBookItemController = new RemoveBookItemController();
      removeBookItemController.Execute(input);

      ShowData(removeBookItemController.ResponseModel);
    }

    private static void RemovePropertyCommand()
    {
      string input = Console.ReadLine();
      var removeBookCatalogPropertyController = new RemoveBookCatalogPropertyController();
      removeBookCatalogPropertyController.Execute(input);

      ShowData(removeBookCatalogPropertyController.ResponseModel);
    }

    private static void QueryAllPropertyCommand()
    {
      var queryAllBookCatalogPropertiesController = new QueryAllBookCatalogPropertiesController();
      queryAllBookCatalogPropertiesController.Execute();

      ShowData(queryAllBookCatalogPropertiesController.ResponseModel);
    }

    private static void ModifyItemCommand()
    {
      string input = Console.ReadLine();

      var modifyBookItemController = new ModifyBookItemController();
      modifyBookItemController.Execute(input);

      ShowData(modifyBookItemController.ResponseModel);
    }

    private static void AddItemCommand()
    {
      string input = Console.ReadLine();

      var addBookCatalogPropertyController = new AddBookCatalogPropertyController();
      addBookCatalogPropertyController.Execute(input);

      ShowData(addBookCatalogPropertyController.ResponseModel);
    }

    private static void ModifyPropertyCommand()
    {
      string input = Console.ReadLine();

      var modifyBookCatalogPropertyController = new ModifyBookCatalogPropertyController();
      modifyBookCatalogPropertyController.Execute(input);

      ShowData(modifyBookCatalogPropertyController.ResponseModel);
    }

    private static void AddPropertyCommand()
    {
      string input = Console.ReadLine();

      var addBookCatalogPropertyController = new AddBookCatalogPropertyController();
      addBookCatalogPropertyController.Execute(input);

      ShowData(addBookCatalogPropertyController.ResponseModel);

    }

    public static string GetCommand()
    {
      return Console.ReadLine().ToUpper();
    }
  }
}