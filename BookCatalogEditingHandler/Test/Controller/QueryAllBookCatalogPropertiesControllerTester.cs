using System.Collections.Generic;
using System.Data.Common;
using BookCatalogController;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.ResponseModel;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class QueryAllBookCatalogPropertiesControllerTester : GivenBookCatalogPropertyContextTester
  {
    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new QueryAllBookCatalogPropertiesController());
    }

    [Test]
    public void QueryAll()
    {
      int previousCount = BookCatalogContext.CatalogProperties.Count;
      var controller = new QueryAllBookCatalogPropertiesController();
      controller.Execute();
      
      Assert.AreEqual(previousCount, BookCatalogContext.CatalogProperties.Count);
      AssertAreEqualPropertyLists(BookCatalogContext.CatalogProperties, controller.PresentableQueryList);
      Assert.AreEqual(ConcatinateList(BookCatalogContext.CatalogProperties), controller.ControlPresenter.PresentedData);
    }

    private string ConcatinateList(List<CatalogProperty> catalogProperties)
    {
      string result = "";
      foreach(var property in catalogProperties)
        result += (property.Name + ", " + property.Value + "\n") ;

      return result;
    }

    private void AssertAreEqualPropertyLists(List<CatalogProperty> catalogProperties, List<PresentableCatalogProperty> presentableQueryList)
    {
      for (int indexProperty = 0; indexProperty < catalogProperties.Count; indexProperty ++)
      {
        Assert.AreEqual(catalogProperties[indexProperty].Name, presentableQueryList[indexProperty].Name);
        Assert.AreEqual(catalogProperties[indexProperty].Value, presentableQueryList[indexProperty].Value);
      }
    }
  }
}