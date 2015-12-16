using System;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class ModifyBookItemController : Controller
  {
    private ModifyBookItemResponseModel _responseModel;

    public ModifyBookItemResponseModel ResponseModel
    {
      get { return _responseModel;}
    }

    public void Execute(string input)
    {
      string[] inputs = input.Split(',');
      var request = ModifyBookItemRequestModelFactory.Create(Convert.ToInt32(inputs[0]), inputs[1], inputs[2]);
      _responseModel = (ModifyBookItemResponseModel)RequestExecutor.Execute(request);
    }
  }
}