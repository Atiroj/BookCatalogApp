using System.Collections.Generic;
using System.Threading;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Usecase
{
  internal class AddBookCatalogPropertyUsecase
  {
    public AddBookCatalogProperyResponseModel Execute(AddBookCatalogPropertyRequestModel requestModel)
    {
      var addCatalogPropertyRequestModel = requestModel as AddBookCatalogPropertyRequestModelImpl;

      var addCatalogPropertyResponseModel = new AddBookCatalogProperyResponseModelImpl();

      if (null == addCatalogPropertyRequestModel)
        addCatalogPropertyResponseModel.ExecuteResult = false;
      else
      {
        var catalogProperty = new CatalogProperty(
          addCatalogPropertyRequestModel.Name, addCatalogPropertyRequestModel.Value);
        BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Add(catalogProperty);

        addCatalogPropertyResponseModel.ExecuteResult = true;
      }
      return addCatalogPropertyResponseModel;
    }
  }
}