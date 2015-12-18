using System;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;

namespace BookCatalogEditingHandler.Usecase
{
  internal class ModifyBookCatalogPropertyUsecase
  {
    public ModifyBookCatalogPropertyResponseModel Execute(ModifyBookCatalogPropertyRequestModel requestModel)
    {
      var modifyCatalogProeprtyRequestModel = requestModel as ModifyBookCatalogPropertyRequestModelImpl;

      var modifyCatalogProppertyResponseModel = new ModifyBookCatalogPropertyResponseModelImpl();
      if (null == modifyCatalogProeprtyRequestModel)
        modifyCatalogProppertyResponseModel.ExecuteResult = false;
      else
      {
        if (modifyCatalogProeprtyRequestModel.Index >= BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties.Count)
          throw new ArgumentOutOfRangeException("Index");

        var catalogProperty = new CatalogProperty(modifyCatalogProeprtyRequestModel.Name, modifyCatalogProeprtyRequestModel.Value);

        BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties[modifyCatalogProeprtyRequestModel.Index] = catalogProperty;
        modifyCatalogProppertyResponseModel.ExecuteResult = true;
      }
         
      return modifyCatalogProppertyResponseModel;
    }
  }
}