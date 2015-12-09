using System.Linq;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;

namespace BookCatalogEditingHandler.Usecase
{
  internal class QueryAllCatalogPropertiesUsecase
  {
    public QueryAllCatalogPropertiesResponseModel Execute(QueryAllCatalogPropertiesRequestModel requestModel)
    {
      var queryAllCatalogPropertiesRequestModel = requestModel as QueryAllCatalogPropertiesRequestModelImpl;
      
      var queryAllCatalogPropertiesResponseModel = new QueryAllCatalogPropertiesResponseModelImpl();

      if (null == queryAllCatalogPropertiesRequestModel)
        queryAllCatalogPropertiesResponseModel.ExecuteResult = false;
      else
      {
       queryAllCatalogPropertiesResponseModel = CreateRespondModel();
        queryAllCatalogPropertiesResponseModel.ExecuteResult = true;
      }
      return queryAllCatalogPropertiesResponseModel;
    }

    private QueryAllCatalogPropertiesResponseModelImpl CreateRespondModel()
    {
      QueryAllCatalogPropertiesResponseModelImpl result = new QueryAllCatalogPropertiesResponseModelImpl
      {
        PresentableCatalogProperties = BookCatalogContext.CatalogProperties.Select
          (
            catalogProperty => new PresentableCatalogProperty(
              catalogProperty.Name, catalogProperty.Value)
          ).ToList()
      };

      return result;
    }
  }
}