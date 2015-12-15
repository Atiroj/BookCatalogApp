using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;
//using BookCatalogEditor.ResponseModelFactory;
//using BookCatelogEditingHandler.Usecase;

namespace BookCatalogEditor
{
  internal class PrintPropertiesController : Controller
  {
    public bool Execute()
    {
     /* QueryAllCatalogPropertiesResponseModel responseModel = QueryAllCatalogPropertiesResponseModelFactory.Create();
      ConsolePresenter presenter = new ConsolePresenter(new ConsoleView());

      return presenter.Execute(responseModel); */
      return true;
    }
  }

  internal class ConsolePresenter 
  {
    private readonly ConsoleView _view;

    public ConsolePresenter(ConsoleView view)
    {
      _view = view;
    }

    public bool Execute(QueryAllCatalogPropertiesResponseModel responseModel)
    {

      if (null == responseModel)
        return false;

      return _view.Execute(TranslateToViewModel(responseModel));
    }

    private List<KeyValuePair<string, string>> TranslateToViewModel(QueryAllCatalogPropertiesResponseModel queryAllCatalogPropertiesRespondModel)
    {
      var result = queryAllCatalogPropertiesRespondModel.PresentableCatalogProperties.Select
        (
          presentableCatalogProperty => new KeyValuePair<string, string>
            (
            presentableCatalogProperty.Name,
            presentableCatalogProperty.Value
            )
        ).ToList();

      return result;
    }
  }

  internal class ConsoleView
  {
    public bool Execute(List<KeyValuePair<string, string>> nameValuePairs)
    {
      nameValuePairs.ForEach(nameValue => Console.WriteLine("name = \"{0}\" \"{1}\"", nameValue.Key, nameValue.Value));
      return true;
    }
  }
}