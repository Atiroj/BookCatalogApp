using System.Collections.Generic;
using BookCatalogEditingHandler.ResponseModel;
using NUnit.Framework;

namespace BookCatalogEditingHandler.ResponseModel
{
  public interface QueryAllCatalogPropertiesResponseModel : ResponseModel
  {
    List<PresentableCatalogProperty> PresentableCatalogProperties { get; }
    bool ExecuteResult { get; }
  }
}