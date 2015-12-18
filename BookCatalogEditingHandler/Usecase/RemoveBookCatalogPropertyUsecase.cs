using System;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;

namespace BookCatalogEditingHandler.Usecase
{
  internal class RemoveBookCatalogPropertyUsecase
  {
    public RemoveBookCatalogPropertyResponseModel Execute(RemoveBookCatalogPropertyRequestModel requestModel)
    {
      var removeBookCatalogPropertyRequestModel = requestModel as RemoveBookCatalogPropertyRequestModelImpl;

      var removeBookCatalogPropertyResponseModel = new RemoveBookCatalogPropertyResponseModelImpl();

      if (null == removeBookCatalogPropertyRequestModel)
        removeBookCatalogPropertyResponseModel.ExecuteResult = false;
      else
      {
        if (removeBookCatalogPropertyRequestModel.Index >= BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Count)
          throw new ArgumentOutOfRangeException("Index");

        BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.RemoveAt(removeBookCatalogPropertyRequestModel.Index);
        removeBookCatalogPropertyResponseModel.ExecuteResult = true;
      }
      

      return removeBookCatalogPropertyResponseModel;
    }
  }
}