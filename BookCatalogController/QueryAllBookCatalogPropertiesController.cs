using System.Collections.Generic;
using System.Runtime.InteropServices;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class QueryAllBookCatalogPropertiesController : Controller
  {
    private QueryAllCatalogPropertiesResponseModel _responseModel;

    public QueryAllCatalogPropertiesResponseModel ResponseModel
    {
      get { return _responseModel;}
    }

    public void Execute()
    {
      var request = QueryAllBookCatalogPropertiesModelFactory.Create();
      _responseModel = (QueryAllCatalogPropertiesResponseModel) RequestExecutor.Execute(request);
    }
  }
}