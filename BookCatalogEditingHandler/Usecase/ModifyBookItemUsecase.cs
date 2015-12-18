using System;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;

namespace BookCatalogEditingHandler.Usecase
{
  internal class ModifyBookItemUsecase
  {
    public ModifyBookItemResponseModel Execute(ModifyBookItemRequestModel requestModel)
    {
      var modifyBookItemRequestModel = requestModel as ModifyBookItemRequestModelImpl;

      var modifyBookItemResponseModel = new ModifyBookItemResponseModelImpl();

      if (null == modifyBookItemRequestModel)
        modifyBookItemResponseModel.ExecuteResult = false;
      else
      {
        if (modifyBookItemRequestModel.Index >= BookCatalogContext.BookCatalogDataGateWay.BookItems.Count)
          throw new ArgumentOutOfRangeException("Index");

        var bookItem = new BookItem(modifyBookItemRequestModel.Name, modifyBookItemRequestModel.Publisher);
        BookCatalogContext.BookCatalogDataGateWay.BookItems[modifyBookItemRequestModel.Index] = bookItem;
        modifyBookItemResponseModel.ExecuteResult = true;
      }
      

      return modifyBookItemResponseModel;
    }
  }
}