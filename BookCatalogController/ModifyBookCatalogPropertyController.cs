using System;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class ModifyBookCatalogPropertyController : Controller
  {
    private ModifyBookCatalogPropertyResponseModel _responseModel;

    public ModifyBookCatalogPropertyResponseModel ResponseModel 
    {
      get { return _responseModel; }
    }

    public void Execute(string input)
    {
      string[] inputs = input.Split(',');
      var request = ModifyBookCatalogPropertyRequestModelFactory.Create((Convert.ToInt32(inputs[0])), inputs[1], inputs[2]);
      _responseModel = (ModifyBookCatalogPropertyResponseModel)RequestExecutor.Execute(request);
    }
  }
}