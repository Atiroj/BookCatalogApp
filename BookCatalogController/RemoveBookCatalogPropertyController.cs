using System;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class RemoveBookCatalogPropertyController : Controller
  {
    public RemoveBookCatalogPropertyResponseModel _responseModel;

    public RemoveBookCatalogPropertyResponseModel ResponseModel
    {
      get { return _responseModel;}
    }

    public void Execute(string input)
    {
      var request = RemoveBookCatalogPropertyModelFactory.Create(Convert.ToInt32(input));
      _responseModel = (RemoveBookCatalogPropertyResponseModel) RequestExecutor.Execute(request);
    }
  }
}