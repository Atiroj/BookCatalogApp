using System.Collections.Generic;
using NUnit.Framework;

namespace BookCatalogEditingHandler.ResponseModel
{
  internal class QueryAllCatalogPropertiesResponseModelImpl : QueryAllCatalogPropertiesResponseModel
  {
    public List<PresentableCatalogProperty> PresentableCatalogProperties { get; set; }
    public bool ExecuteResult { get; set; }
  }
}