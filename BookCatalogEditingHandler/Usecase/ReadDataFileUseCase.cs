using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;

namespace BookCatelogEditingHandler
{
  public class ReadDataFileUseCase 
  {
    public ReadDataFileResponseModel Execute(ReadDataFileRequestModel request)
    {
      var readDataFileResponseModel = new ReadDataFileResponseModelImpl();
      readDataFileResponseModel.ExecuteResult = BookCatalogContext.BookCatalogDataGateWay.Read(request.FileName);

      return readDataFileResponseModel;
    }
  }
}