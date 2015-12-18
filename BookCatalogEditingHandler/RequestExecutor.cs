using System;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditingHandler.Usecase;

namespace BookCatelogEditingHandler
{
  public static class RequestExecutor
  {
    public static ResponseModel Execute(RequestModel request)
    {
      if (request is AddBookCatalogPropertyRequestModel)
      {
        var usecase = new AddBookCatalogPropertyUsecase();
        return usecase.Execute((AddBookCatalogPropertyRequestModel) request);
      }
      else if (request is AddBookItemRequestModel)
      {
        var usecase = new AddBookItemUsecase();
        return usecase.Execute((AddBookItemRequestModel) request);
      }
      else if (request is ModifyBookCatalogPropertyRequestModel)
      {
        var usecase = new ModifyBookCatalogPropertyUsecase();
        return usecase.Execute((ModifyBookCatalogPropertyRequestModel) request);
      }
      else if (request is ModifyBookItemRequestModel)
      {
        var usecase = new ModifyBookItemUsecase();
        return usecase.Execute((ModifyBookItemRequestModel) request);
      }
      else if (request is QueryAllCatalogPropertiesRequestModel)
      {
        var usecase = new QueryAllCatalogPropertiesUsecase();
        return usecase.Execute((QueryAllCatalogPropertiesRequestModel) request);
      }
      else if (request is RemoveBookCatalogPropertyRequestModel)
      {
        var usecase = new RemoveBookCatalogPropertyUsecase();
        return usecase.Execute((RemoveBookCatalogPropertyRequestModel) request);
      }
      else if (request is RemoveBookItemRequestModel)
      {
        var usecase = new RemoveBookItemUsecase();
        return usecase.Execute((RemoveBookItemRequestModel) request);
      }
      else if (request is ReadDataFileRequestModel)
      {
        var usecase = new ReadDataFileUseCase();
        return usecase.Execute((ReadDataFileRequestModel) request);
      }
      else
      {
        throw new NotSupportedException("Request type wasn't supported.");
      }
    }
  }
}