using System;
using BookCatalogController;
using BookCatalogEditingHandler.ResponseModel;

namespace BookCatalogConsole
{
  public class ConsolePresenter : Presenter
  {
    private ConsoleView _view;

    public ResponseModel ResponseModel { get; set; }

    public ConsoleView View
    {
      get { return _view; } 
    }

    public ConsolePresenter()
    {
      _view = new ConsoleView();
    }

    

    public void GenerateView()
    {
      if (ResponseModel is AddBookCatalogProperyResponseModel)
      {
        _view.Data = ResponseModel.ExecuteResult == true ? "Property has been added" : "FAIL to add property";
      }
      else if (ResponseModel is AddBookItemResponseModel)
      {
        _view.Data = ResponseModel.ExecuteResult == true ? "Item has been added" : "FAIL to add Item";
      }
      else if (ResponseModel is ModifyBookCatalogPropertyResponseModel)
      {
        _view.Data = ResponseModel.ExecuteResult == true ? "Property has been modified" : "FAIL to modify Property";
      }
      else if (ResponseModel is ModifyBookItemResponseModel)
      {
        _view.Data = ResponseModel.ExecuteResult == true ? "Item has been modified" : "FAIL to modify Item";
      }
      else if (ResponseModel is QueryAllCatalogPropertiesResponseModel)
      {
        _view.Data = ResponseModel.ExecuteResult == true
          ? GenerateQueryAllCatalogPropertyView()
          : "FAIL to query Propery";
      }
      else if (ResponseModel is RemoveBookCatalogPropertyResponseModel)
      {
        _view.Data = ResponseModel.ExecuteResult == true ? "Property has been removed" : "FAIL to remove property";
      }
      else if (ResponseModel is RemoveBookItemResponseModel)
      {
        _view.Data = ResponseModel.ExecuteResult == true ? "Item has been removed" : "FAIL to remove item";
      }
      else if (ResponseModel is ReadDataFileResponseModel)
      {
        _view.Data = ResponseModel.ExecuteResult == true ? "File has been read" : "FAIL to read file";
      }

      _view.ShowData();
    }

    private string GenerateQueryAllCatalogPropertyView()
    {
      string resultQuery = "";

      var response = ResponseModel as QueryAllCatalogPropertiesResponseModel;
      foreach(var catalogProperty in response.PresentableCatalogProperties )
        resultQuery += catalogProperty.Name + ", " + catalogProperty.Value + "\n";

      return resultQuery;
    }
  }
}