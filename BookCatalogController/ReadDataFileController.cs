using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class ReadDataFileController : Controller
  {
    private ReadDataFileResponseModel _responseModel;

    public ReadDataFileResponseModel ResponseModel
    {
      get { return _responseModel; }
    }

    public void Execute(string fileName)
    {
      var request = ReadDataFileRequestModelFactory.Create(fileName);
      _responseModel = (ReadDataFileResponseModel) RequestExecutor.Execute(request);
    }
  }
}