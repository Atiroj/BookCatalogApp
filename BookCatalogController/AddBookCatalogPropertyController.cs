using System.Linq.Expressions;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditingHandler.Usecase;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class AddBookCatalogPropertyController : Controller
  {
    private AddBookCatalogProperyResponseModel _responseModel;

    public AddBookCatalogProperyResponseModel ResponseModel
    {
      get { return _responseModel; }
    }

    public void Execute(string input)
    {
      string[] inputs = input.Split(',');
      var request = AddBookCatalogPropertyRequestModelFactory.Create(inputs[0], inputs[1]);
      _responseModel = (AddBookCatalogProperyResponseModel)RequestExecutor.Execute(request);
    }
    
  }
}