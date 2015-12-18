using System;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;

namespace BookCatalogEditingHandler.Usecase
{
  internal class RemoveBookItemUsecase
  {
    public RemoveBookItemResponseModel Execute(RemoveBookItemRequestModel requestModel)
    {
      var removeItemRequestModel = requestModel as RemoveBookItemRequestModelImpl;
      
      var removeItemResponseModel = new RemoveBookItemResponseModelImpl();

      if (null == removeItemRequestModel)
        removeItemResponseModel.ExecuteResult = false;
      else
      {
        if (removeItemRequestModel.Index >= BookCatalogContext.BookCatalogDataGateWay.BookItems.Count)
          throw new ArgumentOutOfRangeException("Index");

        BookCatalogContext.BookCatalogDataGateWay.BookItems.RemoveAt(removeItemRequestModel.Index);
        removeItemResponseModel.ExecuteResult = true;
      }
     
      return removeItemResponseModel;
    }
  }
}
