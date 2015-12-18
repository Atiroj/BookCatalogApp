using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditingHandler.Usecase;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class QueryAllCatalogPropertiesUsecaseTester : GivenBookCatalogPropertyContextTester
  {
    private QueryAllCatalogPropertiesUsecase _usecase;

    [SetUp]
    public new void SetUp()
    {
      _usecase = new QueryAllCatalogPropertiesUsecase();
    }

    [Test]
    public void QueryAllCatalogProperties()
    {
      var request = new QueryAllCatalogPropertiesRequestModelImpl();
      
      var response = _usecase.Execute(request);
      AssertCatalogPropertiesAreEqual(BookCatalogContext.BookCatalogDataGateWay.BookCatalogProperties, response.PresentableCatalogProperties );
    }

    private void AssertCatalogPropertiesAreEqual
      (List<CatalogProperty> catalogProperties, List<PresentableCatalogProperty> presentableCatalogProperties)
    {
      Assert.AreEqual(catalogProperties.Count, presentableCatalogProperties.Count);

      for (int indexProperty = 0; indexProperty < catalogProperties.Count; indexProperty++)
      {
        Assert.AreEqual(catalogProperties[indexProperty].Name, presentableCatalogProperties[indexProperty].Name);
        Assert.AreEqual(catalogProperties[indexProperty].Value, presentableCatalogProperties[indexProperty].Value);
      }     
    }

    
  }
}