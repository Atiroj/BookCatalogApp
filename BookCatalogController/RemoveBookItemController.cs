using System;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class RemoveBookItemController : Controller
  {
    private RemoveBookItemResponseModel _responseModel;

    public RemoveBookItemResponseModel ResponseModel
    {
      get { return _responseModel;}
    }

    public void Execute(string input)
    {
      int index = Convert.ToInt32(input);
      var request = RemoveBookItemRequestModelFactory.Create(index);
      _responseModel = (RemoveBookItemResponseModel)RequestExecutor.Execute(request);
    }

    
  }
}