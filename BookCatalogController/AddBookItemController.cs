using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class AddBookItemController
  {
    private AddBookItemResponseModel _responseModel;

    public AddBookItemResponseModel ResponseModel
    {
      get { return _responseModel; }
    }

    public void Execute(string input)
    {
      string[] inputs = input.Split(',');
      var request = AddBookItemRequestModelFactory.Create(inputs[0], inputs[1]);
      _responseModel = (AddBookItemResponseModel)RequestExecutor.Execute(request);
    }
    
  }
}