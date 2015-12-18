using System.Collections.Generic;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Usecase
{
    internal class AddBookItemUsecase
    {
      public AddBookItemResponseModel Execute(AddBookItemRequestModel requestModel)
      {
        var addBookItemRequestModel = requestModel as AddBookItemRequestModelImpl;
        
        var addBookItemResponseModel = new AddBookItemResponseModelImpl();

        if (null == addBookItemRequestModel)
           addBookItemResponseModel.ExecuteResult = false;
        else
        {
          var bookItem = new BookItem(addBookItemRequestModel.Name, addBookItemRequestModel.Publisher);
          BookCatalogContext.BookCatalogDataGateWay.BookItems.Add(bookItem);

          addBookItemResponseModel.ExecuteResult = true;
        }
      
        return addBookItemResponseModel;
      }
    }
}